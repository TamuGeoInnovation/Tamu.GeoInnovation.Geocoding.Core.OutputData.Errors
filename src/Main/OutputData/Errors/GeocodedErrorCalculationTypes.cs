using System;

namespace USC.GISResearchLab.Geocoding.Core.OutputData.Error
{

    public enum GeocodedErrorCalculationType
    {
        unknown,
        featureBoundingBoxArea,
        featureGeometryArea,
        featureConvexHullArea,
    }

    public class GeocodedErrorCalculationTypes
    {

        public static string UNKNOWN = "UNKOWN";
        public static string FEATURE_BOUNDING_BOX_AREA = "feature bounding box area";
        public static string FEATURE_CONVEX_HULL_AREA = "feature convex hull area";
        public static string FEATURE_GEOMETRY_AREA = "feature geometry area";


        public static string NameFromType(GeocodedErrorCalculationType type)
        {
            string ret = null;
            switch (type)
            {
                case GeocodedErrorCalculationType.unknown:
                    ret = UNKNOWN;
                    break;
                case GeocodedErrorCalculationType.featureBoundingBoxArea:
                    ret = FEATURE_BOUNDING_BOX_AREA;
                    break;
                case GeocodedErrorCalculationType.featureGeometryArea:
                    ret = FEATURE_GEOMETRY_AREA;
                    break;
                case GeocodedErrorCalculationType.featureConvexHullArea:
                    ret = FEATURE_CONVEX_HULL_AREA;
                    break;
                default:
                    throw new Exception("Unexpected error calculation type: " + type);
            }
            return ret;
        }

    }
}
