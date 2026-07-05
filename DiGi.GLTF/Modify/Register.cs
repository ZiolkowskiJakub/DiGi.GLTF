using DiGi.GLTF.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.GLTF
{
    public static partial class Modify
    {
        private static readonly object gLTFNodeConvertersLock = new();
        private static List<IGLTFNodeConverter> gLTFNodeConverters = [];

        /// <summary>
        /// Registers the specified <see cref="IGLTFNodeConverter"/> so it is consulted by <see cref="Convert.ToGLTF_GLTFNodes(Core.Interfaces.ISerializableObject?, double)"/>.
        /// <para>Converters are consulted in registration order; the first converter whose CanConvert returns true wins, so register more specific converters before more general ones.</para>
        /// </summary>
        /// <param name="gLTFNodeConverter">The converter to register. This value can be null.</param>
        /// <returns>True if the converter was registered; otherwise, false.</returns>
        public static bool Register(IGLTFNodeConverter? gLTFNodeConverter)
        {
            if (gLTFNodeConverter is null)
            {
                return false;
            }

            lock (gLTFNodeConvertersLock)
            {
                // Copy-on-write: readers work on immutable snapshots without locking.
                List<IGLTFNodeConverter> gLTFNodeConverters_Temp = [.. gLTFNodeConverters];
                gLTFNodeConverters_Temp.RemoveAll(x => x.GetType() == gLTFNodeConverter.GetType());
                gLTFNodeConverters_Temp.Add(gLTFNodeConverter);
                gLTFNodeConverters = gLTFNodeConverters_Temp;
            }

            return true;
        }

        /// <summary>
        /// Registers all <see cref="IGLTFNodeConverter"/> implementations with a public parameterless constructor found in the specified assembly.
        /// <para>This enables plugin-like extensibility: a consuming project registers its assembly once at startup and any converter class added later is picked up without further registration code.</para>
        /// </summary>
        /// <param name="assembly">The assembly to scan. This value can be null.</param>
        /// <returns>The number of converters registered.</returns>
        public static int Register(Assembly? assembly)
        {
            if (assembly is null)
            {
                return 0;
            }

            int result = 0;
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsAbstract || type.IsInterface || !typeof(IGLTFNodeConverter).IsAssignableFrom(type))
                {
                    continue;
                }

                if (type.GetConstructor(Type.EmptyTypes) is null)
                {
                    continue;
                }

                if (Activator.CreateInstance(type) is IGLTFNodeConverter gLTFNodeConverter && Register(gLTFNodeConverter))
                {
                    result++;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the currently registered <see cref="IGLTFNodeConverter"/> snapshot in registration order.
        /// </summary>
        /// <returns>An immutable snapshot of the registered converters.</returns>
        internal static List<IGLTFNodeConverter> RegisteredGLTFNodeConverters()
        {
            return gLTFNodeConverters;
        }
    }
}
