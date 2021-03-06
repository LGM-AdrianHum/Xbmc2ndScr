﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TmdbWrapper.Utilities;


namespace TmdbWrapper.Persons
{
    /// <summary>
    /// Person
    /// </summary>
    public class Person : ITmdbObject
    {
        #region private fields
        private Credit _credits;
        private Uri _homepage;

        #endregion

        #region properties
        /// <summary>
        /// Indicates wether this person is an adult actor
        /// </summary>
        public bool Adult { get; private set; }
        /// <summary>
        /// Aliases this person is known by.
        /// </summary>
        public string[] Aliases { get; private set; }
        /// <summary>
        /// Biography of this person.
        /// </summary>
        public string Biography { get; private set; }
        /// <summary>
        /// Birthday 
        /// </summary>
        public string Birthday { get; private set; }
        /// <summary>
        /// Date of death
        /// </summary>
        public string Deathday { get; private set; }
        /// <summary>
        /// Uri of possible homepage.
        /// </summary>
        public Uri Homepage
        {
            get { return _homepage; }
            private set { _homepage = value; }
        }

        /// <summary>
        /// Id of this person
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Name of this person.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Place of birth
        /// </summary>
        public string PlaceOfBirth { get; private set; }
        /// <summary>
        /// Path of the profile.
        /// </summary>
        public string ProfilePath { get; private set; }
        /// <summary>
        /// Gets the credits associated to this person.
        /// </summary>
        public Credit Credits
        {
            get
            {
                if (_credits == null)
                {
                    var task = TheMovieDb.GetCreditsAsync(Id);
                    task.RunSynchronously();
                    _credits = task.Result;
                }
                return _credits;
            }
        }
        #endregion

        #region interface implementations
        void ITmdbObject.ProcessJson(JObject jsonObject)
        {
            Adult = jsonObject.GetSafeBoolean("adult");
            Biography = jsonObject.GetSafeString("biography");
            Birthday = jsonObject.GetSafeString("birthday");
            Deathday = jsonObject.GetSafeString("deathday");
            System.Uri.TryCreate(jsonObject.GetSafeString("homepage"), UriKind.Absolute, out _homepage);
            Id = (int)jsonObject.GetSafeNumber("id");
            Name = jsonObject.GetSafeString("name");
            PlaceOfBirth = jsonObject.GetSafeString("place_of_birth");
            ProfilePath = jsonObject.GetSafeString("profile_path");
            _credits = jsonObject.ProcessObject<Credit>("credits");
        }
        #endregion

        #region image uri's
        /// <summary>
        /// Uri to the profile image.
        /// </summary>
        /// <param name="size">The size for the image as required</param>
        /// <returns>The uri to the sized image</returns>
        public Uri Uri(ProfileSize size)
        {
            return Utilities.Extensions.MakeImageUri(size.ToString(), ProfilePath);
        }
        #endregion
    }
}
