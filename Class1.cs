using NetTopologySuite.IO;
using System.Runtime.InteropServices;

namespace wellknown.net
{
    public class Class1
    {
        [DllExport(CallingConvention.StdCall)]
        public static string GeoJsonFromWKT(string wkt)
        {
            string json = string.Empty;
            try
            {
                var reader = new WKTReader();
                var geo = reader.Read(wkt);

                var writer = new GeoJsonWriter();
                json = writer.Write(geo);
            }
            catch { }
            
            return json;
        }

    }
}
