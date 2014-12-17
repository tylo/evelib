﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using eZet.EveLib.Modules.Models.Entities;
using eZet.EveLib.Modules.Models.Shared;

namespace eZet.EveLib.Modules.Models.Resources {
    /// <summary>
    ///     Represents a CREST /allliances/$allianceId/ reponse
    /// </summary>
    [DataContract]
    public sealed class CrestAlliance : CrestResource {
        public CrestAlliance() {
            Version = "application/vnd.ccp.eve.Alliance-v1+json";
        }

        /// <summary>
        ///     The alliance ID
        /// </summary>
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        ///     The alliance name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }


        /// <summary>
        ///     The alliance ticker
        /// </summary>
        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }

        /// <summary>
        ///     The alliance creation date
        /// </summary>
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }


        /// <summary>
        ///     The number of corporations in the alliance
        /// </summary>
        [DataMember(Name = "corporationsCount")]
        public int CorporationsCount { get; set; }

        /// <summary>
        ///     The alliance description
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     True if the alliance is deleted, otherwise false
        /// </summary>
        [DataMember(Name = "deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        ///     The alliance URL, if any
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        ///     The alliance executor corporation
        /// </summary>
        [DataMember(Name = "executorCorporation")]
        public CrestLinkedEntity<CrestNotImplemented> ExecutorCorporation { get; set; }

        /// <summary>
        ///     The alliance creator corporation
        /// </summary>
        [DataMember(Name = "creatorCorporation")]
        public CrestLinkedEntity<CrestNotImplemented> CreatorCorporation { get; set; }

        /// <summary>
        ///     The alliance creator character
        /// </summary>
        [DataMember(Name = "creatorCharacter")]
        public CharacterEntry CreatorCharacter { get; set; }

        /// <summary>
        ///     A list of all corporations in the alliance
        /// </summary>
        [DataMember(Name = "corporations")]
        public IList<CorporationEntry> Corporations { get; set; }



 
    }
}