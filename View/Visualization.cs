using System.Runtime.InteropServices;

namespace View
{
    /// <summary>
    /// Einbinden der Visualization.dll in C#
    /// </summary>
    public static class Visualization
    { 
        //[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //static extern bool SetDllDirectory(string path);
        
        /// <summary>
        /// Punkt erstellen
        /// </summary>
        /// <returns>Point ID</returns>
        /// 
        [DllImport("Visualization.dll")]
        public static extern int addPoint();
        /// <summary>
        /// Punktkoordinate setzen
        /// </summary>
        /// <param name="point">Punkt ID</param>
        /// <param name="x">x Koordinate</param>
        /// <param name="y">y Koordinate</param>
        /// <param name="z">z Koordinate</param>
        /// <returns></returns>
        [DllImport("Visualization.dll")]
        public static extern bool updatePoint(int point, float x, float y, float z);
        /// <summary>
        /// Linie erstellen
        /// </summary>
        /// <returns>Linien ID</returns>
        [DllImport("Visualization.dll")]
        public static extern int addLine();
        /// <summary>
        /// Linien Koordinaten setzen
        /// </summary>
        /// <param name="line">Linien ID</param>
        /// <param name="x1">x Koordinate Linienanfang</param>
        /// <param name="y1">y Koordinate Linienanfang</param>
        /// <param name="z1">z Koordinate Linienanfang</param>
        /// <param name="x2">x Koordinate Linienend</param>
        /// <param name="y2">y Koordinate Linienend</param>
        /// <param name="z2">z Koordinate Linienend</param>
        /// <returns></returns>
        [DllImport("Visualization.dll")]
        public static extern bool updateLine(int line, float x1, float y1, float z1, float x2, float y2, float z2);
        /// <summary>
        /// Ausgabe nue Zeichnen
        /// </summary>
        /// <returns></returns>
        [DllImport("Visualization.dll")]
        public static extern int draw();
        /// <summary>
        /// Visualization beenden
        /// </summary>
        /// <returns></returns>
        [DllImport("Visualization.dll")]
        public static extern int close();

        /*public static void SetDirectory(string p)
        {
            SetDllDirectory(p);
        }*/
    }
}
