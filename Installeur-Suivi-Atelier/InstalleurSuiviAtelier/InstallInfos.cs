using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace InstalleurSuiviAtelier
{
    public static class InstallInfos
    {
        public static String repPrincipal;
        public static String zuluPath;
        public static String tomcatBinPath;
        public static String versionInstall;

        public static byte[] getVersionInstall()
        {
            String appWebRessource = InstallInfos.TrouvverNomRessource(versionInstall);
            //Properties.Resources.
            return (byte[])Properties.Resources.ResourceManager.GetObject(appWebRessource);

            //switch (versionInstall)
            //{
            //    case "5.0.6":
            //        return Properties.Resources.SuiviAtelier_5_0_6_pro;
            //    case "5.0.7":
            //        return Properties.Resources.SuiviAtelier_5_0_7_pro;
            //    case "5.0.9":
            //        return Properties.Resources.SuiviAtelier_5_0_9_pro;
            //    case "5.1.1":
            //        return Properties.Resources.SuiviAtelier_5_1_1_pro;
            //    case "5.1.3":
            //        return Properties.Resources.SuiviAtelier_5_1_3_pro;
            //    case "5.1.5":
            //        return Properties.Resources.SuiviAtelier_5_1_5_pro;
            //    case "5.2.0":
            //        return Properties.Resources.SuiviAtelier_5_2_0_pro;
            //    case "5.2.1":
            //        return Properties.Resources.SuiviAtelier_5_2_1_pro;
            //    case "5.2.2":
            //        return Properties.Resources.SuiviAtelier_5_2_2_pro;
            //    case "5.2.3":
            //        return Properties.Resources.SuiviAtelier_5_2_3_pro;
            //    case "5.2.4":
            //        return Properties.Resources.SuiviAtelier_5_2_4_pro;
            //    case "5.2.7":
            //        return Properties.Resources.SuiviAtelier_5_2_7_pro;
            //    case "5.2.8":
            //        return (byte[])Properties.Resources.ResourceManager.GetObject("SuiviAtelier_dqdsqd5_2_8_pro");
            //        return Properties.Resources.SuiviAtelier_5_2_8_pro;
            //    default:
            //        throw new Exception("Erreur. Une version du SA n'est sûrement pas renseignée dans InstallInfos.");
            //}
        }

        private static String TrouvverNomRessource(String version)
        {
            String val = "";
            val = "SuiviAtelier_" + version.Replace(".", "_") + "_pro";          
            return val;
        }


        public static void InstallWebApp(String pathInstall, bool avecVersion)
        {
            String path = Path.GetTempPath();
            path = Path.Combine(path, "SuiviAtelier_" + InstallInfos.versionInstall + ".war");

            //On convertit le fichier présent dans les Resources. On transforme de byte[] en fichier
            File.WriteAllBytes(path, InstallInfos.getVersionInstall());


            if (avecVersion)
            {
                pathInstall = Path.Combine(pathInstall, "SuiviAtelier_" + InstallInfos.versionInstall + "-pro.war");
            }
            else
            {
                pathInstall = Path.Combine(pathInstall, "SuiviAtelier.war");
            }

            try
            {
                File.Move(path, pathInstall);
            }
            catch {
                throw new Exception("Impossible de déplacer l'archive web dans le répertoire d'installation. Vérifiez vos droits Windows.");
            }
        }

        public static string getSvcName()
        {
            string nomRep = Path.GetFileName(InstallInfos.repPrincipal);
            Console.WriteLine(InstallInfos.repPrincipal);
            return "4CAD_SA_" + nomRep;
        }

    }
}
