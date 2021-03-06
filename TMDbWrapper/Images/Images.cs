﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TmdbWrapper.Utilities;


namespace TmdbWrapper.Image
{
    /// <summary>
    /// Images of a movie
    /// </summary>
    public class Images : ITmdbObject
    {
        #region properties
        /// <summary>
        /// Id of the movie
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// List of backdrops
        /// </summary>
        public IReadOnlyList<Backdrop> Backdrops { get; private set; }
        /// <summary>
        /// List of posters
        /// </summary>
        public IReadOnlyList<Poster> Posters { get; private set; }
        #endregion

        #region interface implementations
        void ITmdbObject.ProcessJson(JObject jsonObject)
        {
            Id = (int)jsonObject.GetSafeNumber("id");
            Backdrops = jsonObject.ProcessArray<Backdrop>("backdrops");
            Posters = jsonObject.ProcessArray<Poster>("posters");
        }
        #endregion
    }
}
