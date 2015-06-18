////using USC.GISResearchLab.Common.Utils.Reflections;
using System.Text;
using USC.GISResearchLab.Common.Geographics.Units;

namespace USC.GISResearchLab.Geocoding.Core.OutputData.Error
{
	/// <summary>
	/// Summary description for GeocodedError.
	/// </summary>
	public class GeocodedError
    {
        #region Properties
        private string _GeoError;
        private double _ErrorBounds;
        private LinearUnitTypes _ErrorBoundsUnit;
        private GeocodedErrorCalculationType _ErrorCalculationType;

        public GeocodedErrorCalculationType ErrorCalculationType
        {
            get { return _ErrorCalculationType; }
            set { _ErrorCalculationType = value; }
        }
	
        public string GeoError
        {
            get { return _GeoError; }
            set { _GeoError = value; }
        }
        public double ErrorBounds
        {
            get { return _ErrorBounds; }
            set { _ErrorBounds = value; }
        }
        public LinearUnitTypes ErrorBoundsUnit
        {
            get { return _ErrorBoundsUnit; }
            set { _ErrorBoundsUnit = value; }
        }
        #endregion

        public GeocodedError()
		{
			GeoError = "";
            ErrorBounds = -1;
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(GetType().Name);
            //string[][] properties = ReflectionUtils.GetObjectProperties(this);
            //for (int i = 0; i < properties.Length; i++)
            //{
            //    ret.AppendFormat("{0}: {1}", properties[i][0], properties[i][1]);
            //    ret.AppendLine();
            //}
            return ret.ToString();
        }
	}
}
