﻿using InstgramCSharp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InstgramCSharp.Endpoints
{
    public static class GeographyEndpoints
    {
        /// <summary>
        /// Get recent media from a geography subscription that you created. 
        /// Note: You can only access Geographies that were explicitly created by your OAuth client.
        /// Check the Geography Subscriptions section of the real-time updates page. When you create a subscription to some geography that you define, you will be returned a unique geo-id that can be used in this query.
        /// To backfill photos from the location covered by this geography, use the media search endpoint.
        /// </summary>
        /// <param name="count">Max number of media to return.</param>
        /// <param name="minId">Return media before this min_id.</param>
        /// <returns>JSON result string.</returns>
        public static async Task<string> GetUserBasicInfoAsync(string geoId, string clientId, int count = 0, string minId = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(GeographyEndpointUrlsFactory.CreateRecentGeographyMediaUrl(geoId,clientId, count, minId));
                return response;
            }
        }
    }
}
