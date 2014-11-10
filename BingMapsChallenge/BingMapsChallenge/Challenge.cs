namespace BingMapsChallenge
{
    using System.Net.Http;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class Challenge
    {
        /* Bing Maps Challenge
         * 
         * In this challenge you need to use the Bing Maps API to resolve an address, postal code and country to a geolocation (latitude and longitude).
         * 
         * You will receive three inputs for your method: [1] an address line, [2] a postalcode [3] and a country code.
         * 
         * You must return a double array of length 2. Index 0 of the array shall be the latitude and index 1 shall be the longitude.
         * 
         * Example: If the input were to be the values below:
         *          
         *          addressLine = "Tuborg Boulevard 12"
         *          postalCode  = "2900"
         *          countryCode = "DK"
         *          
         *          Then the result should be a double array (e.g., resultArray) with the following values:
         *          
         *          resultArray[0] = 55.7271614
         *          resultArray[1] = 12.5807505
         *          
         * You need to use the Locations API and create an "Unstructured URL". Read more here: http://msdn.microsoft.com/en-us/library/ff701714.aspx
         * 
         * You also need to sign up for a Bing Maps API key. You can do that here: http://www.microsoft.com/maps/create-a-bing-maps-key.aspx
         * 
         * 
         *   Aq252EVujloGJa11NFEV0UvAjNyQ_jpCIzb1F8rESWMvqYrNmB_-dR9nivxlk3pr
         * 
         * 
         * Good luck!
         */

        public double[] Execute(string addressLine, string postalCode, string countryCode)
        {
            var resultArray = new double[2];
            var client = new HttpClient();
            var requestUri = string.Format("http://dev.virtualearth.net/REST/v1/Locations?CountryRegion={0}&addressLine={1}&postalCode={2}&key=Aq252EVujloGJa11NFEV0UvAjNyQ_jpCIzb1F8rESWMvqYrNmB_-dR9nivxlk3pr",
                countryCode, addressLine, postalCode);
            var result = client.GetAsync(
                requestUri)
                .GetAwaiter()
                .GetResult();
            var jsonTask = result.Content.ReadAsStringAsync();
            jsonTask.Wait();
            var deserializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonTask.Result);
            dynamic coordinates = deserializeObject.resourceSets[0].resources[0].point.coordinates;

            resultArray[0] = coordinates[0];
            resultArray[1] = coordinates[1];
            return resultArray;
        }
    }
}
