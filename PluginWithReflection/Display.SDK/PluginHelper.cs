using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public static class PluginHelper
    {
        public static List<Plug> GetPlugins(string directoryPath)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(directoryPath);

            if (!Directory.Exists(directoryPath))
            {
                throw new FileNotFoundException("Belirtilen klasör bulunamadı");
            }

            List<Plug> plugins = getPluginsInPath(directoryPath);
            return plugins;
        }
        /// <summary>
        /// belirtilen klasördeki Plugin nesnelerini bulmak
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        private static List<Plug> getPluginsInPath(string directoryPath)
        {
            //1. belirtilen klasördeki .dll dosyalarını bul.
            var dllFiles = Directory.GetFiles(directoryPath, "*.dll");
            //2. bu .dll dosyalarını referans ekle ve  uygunsa plugin nesnesi oluştur.
            var plugs = new  List<Plug>();
            foreach (var dllFile in dllFiles) {
                addReference(dllFile, plugs);
            }
            return plugs;

        }
        /// <summary>
        /// Belirtilen .dll dosyasını projeye ekler. Eğer koşullar sağlanıyorsa Display için Plug nesnesi üretir.
        /// </summary>
        /// <param name="dllFile"></param>
        /// <param name="plugs"></param>
        private static void addReference(string dllFile, List<Plug> plugs)
        {
            var assembly = Assembly.LoadFile(dllFile);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type =>
            {
                //bu dllFile'in benim için yazılmış olduğunu nereden bileceğim?
                Plug plug = handShakeApplicationAndType(type, dllFile);
                if (plug != null)
                {
                    plugs.Add(plug);
                }
            });
          
            
        }

        private static Plug handShakeApplicationAndType(Type type, string dllFile)
        {
            Plug plug = null;
            if (type.GetInterface("IPlugin") != null)
            {
                plug = new Plug();
                plug.Path = dllFile;
                plug.FullName = type.FullName;
                /*
                   KarePlugin kare = new KarePlugin();
                   plug.Name = kare.Name
                 */
                dynamic instance = Activator.CreateInstance(type);
                //plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();
                plug.Name = instance.Name;
                
            }
            return plug;
        }

        public static IPlugin CreateInstance(Plug activePlug)
        {
            Assembly assembly = Assembly.LoadFrom(activePlug.Path);
            var instance = assembly.CreateInstance(activePlug.FullName);
            return (IPlugin)instance;
        }

    }
}
