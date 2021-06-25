using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KinectV2Viewer
{
    class GlobalSatics
    {
        public static class GG
        {
            #region //YOLOv3 config
            public struct YOLOv3
            {
                public static bool Loaded = false;
                public static string BasePath = @"C:\Users\DELL PRECISION\Desktop\YoloV4_datasheet\test";
                public static string ConfigFile = Path.Combine(BasePath, "yolov3.cfg");
                public static string WeightsFile = Path.Combine(BasePath, "yolov3_final.weights");
                public static string NamesFile = Path.Combine(BasePath, "yolo.names");

                //public static string BasePath = @"C:\Users\DELL PRECISION\Desktop\ML\YoloV3";
                //public static string ConfigFile = Path.Combine(BasePath, "yolov3.cfg");
                //public static string WeightsFile = Path.Combine(BasePath, "yolov3.weights");
                //public static string NamesFile = Path.Combine(BasePath, "coco.names");
                public static List<string> Names = File.ReadAllLines(NamesFile).ToList<string>();
                public static List<string> Colors = new List<string> {
                "#9b59b6",
                "#3498db",
                "#0095ff",
                "#e74c3c",
                "#34495e",
                "#2ecc71",
                "#f372bf",
                "#14733c",
                "#cc772e",
                "#2ea44f",
                "#2e3acc"
         };

                // use GPU 0
                //public static GpuConfig YOLO_GpuConfig = new GpuConfig();
                //YOLO_GpuConfig.GpuIndex = 0;
            }
            #endregion
        }
    }
}
