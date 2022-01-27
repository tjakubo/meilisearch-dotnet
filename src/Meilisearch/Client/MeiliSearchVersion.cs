namespace Meilisearch
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Deserialized response of the Meilisearch version.
    /// </summary>
    public class MeiliSearchVersion
    {
        /// <summary>
        /// Gets or sets commit SHA for Meilisearch.
        /// </summary>
        [JsonPropertyName("commitSha")]
        public string CommitSha { get; set; }

        /// <summary>
        /// Gets or sets build date of the current version.
        /// </summary>
        [JsonPropertyName("commitDate")]
        public string CommitDate { get; set; }

        /// <summary>
        /// Gets or sets information about Meilisearch version.
        /// </summary>
        [JsonPropertyName("pkgVersion")]
        public string Version { get; set; }
    }
}
