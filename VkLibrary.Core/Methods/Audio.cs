using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Audio;
using VkLibrary.Core.Types.Audio;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Audio API section.
    /// </summary>
    public class Audio
    {
        private readonly VkLibrary _vkontakte;

        internal Audio(VkLibrary vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of audio files of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.get">audio.get</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the audio file. Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="albumId">Audio album ID.</param>
        /// <param name="audioIds">IDs of the audio files to return.</param>
        /// <param name="needUser">'1' — to return information about users who uploaded audio files</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<ApiItemsResponse<AudioFull>> Get(int? ownerId = null, int? albumId = null,
            IEnumerable<int?> audioIds = null, bool? needUser = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (audioIds != null)
                parameters.Add("audio_ids", audioIds.ToApiString());
            if (needUser != null)
                parameters.Add("need_user", needUser.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<AudioFull>>("audio.get", parameters);
        }

        /// <summary>
        /// Returns information about audio files by their IDs.
        /// Docs: <see href="https://vk.com/dev/audio.getById">audio.getById</see>
        /// </summary>
        /// <param name="audios">Audio file IDs, in the following format:; "{owner_id}_{audio_id}"</param>
        public async Task<IEnumerable<AudioFull>> GetById(IEnumerable<string> audios = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audios != null)
                parameters.Add("audios", audios.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<AudioFull>>("audio.getById", parameters);
        }

        /// <summary>
        /// Returns lyrics associated with an audio file.
        /// Docs: <see href="https://vk.com/dev/audio.getLyrics">audio.getLyrics</see>
        /// </summary>
        /// <param name="lyricsId">
        /// Lyrics ID (could be obtained with [vk.com/dev/audio.get|audio.get],
        /// [vk.com/dev/audio.getById|audio.getById], or [vk.com/dev/audio.search|audio.search] methods).
        /// </param>
        public async Task<Lyrics> GetLyrics(int? lyricsId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (lyricsId != null)
                parameters.Add("lyrics_id", lyricsId.ToApiString());

            return await _vkontakte.GetAsync<Lyrics>("audio.getLyrics", parameters);
        }

        /// <summary>
        /// Returns a list of audio matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/audio.search">audio.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'The Beatles').</param>
        /// <param name="autoComplete">
        /// '1' — to correct for mistakes in the search query (e.g., if you enter 'Beetles', the system
        /// will search for 'Beatles').
        /// </param>
        /// <param name="lyrics">'1' — to return only audio files that have associated lyrics.</param>
        /// <param name="performerOnly">'1' — to search only by artist name.</param>
        /// <param name="sort">Sort order: ; '1' — by duration;; '2' — by popularity;; '0' — by date added.</param>
        /// <param name="searchOwn">'1' — to search among current user's audios. By default: '0'.</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<ApiItemsResponse<AudioFull>> Search(string q = null, bool? autoComplete = null,
            bool? lyrics = null, bool? performerOnly = null, int? sort = null, bool? searchOwn = null,
            int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (autoComplete != null)
                parameters.Add("auto_complete", autoComplete.ToApiString());
            if (lyrics != null)
                parameters.Add("lyrics", lyrics.ToApiString());
            if (performerOnly != null)
                parameters.Add("performer_only", performerOnly.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (searchOwn != null)
                parameters.Add("search_own", searchOwn.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<AudioFull>>("audio.search", parameters);
        }

        /// <summary>
        /// Returns the server address to [vk.com/dev/upload_files_2|upload audio files].
        /// Docs: <see href="https://vk.com/dev/audio.getUploadServer">audio.getUploadServer</see>
        /// </summary>
        public async Task<GetUploadServerResponse> GetUploadServer()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<GetUploadServerResponse>("audio.getUploadServer", parameters);
        }

        /// <summary>
        /// Saves audio files after successful [vk.com/dev/upload_files_2|uploading].
        /// Docs: <see href="https://vk.com/dev/audio.save">audio.save</see>
        /// </summary>
        /// <param name="server">
        /// This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the
        /// server].
        /// </param>
        /// <param name="audio">
        /// This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the
        /// server].
        /// </param>
        /// <param name="hash">
        /// This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the
        /// server].
        /// </param>
        /// <param name="artist">The name of the artist. By default, this is obtained from ID3 tags.</param>
        /// <param name="title">The title of the audio file. By default, this is obtained from ID3 tags.</param>
        public async Task<IEnumerable<Types.Audio.Audio>> Save(int? server = null, string audio = null,
            string hash = null, string artist = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (audio != null)
                parameters.Add("audio", audio);
            if (hash != null)
                parameters.Add("hash", hash);
            if (artist != null)
                parameters.Add("artist", artist);
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<IEnumerable<Types.Audio.Audio>>("audio.save", parameters);
        }

        /// <summary>
        /// Copies an audio file to a user page or community page.
        /// Docs: <see href="https://vk.com/dev/audio.add">audio.add</see>
        /// </summary>
        /// <param name="audioId">Audio file ID.</param>
        /// <param name="ownerId">
        /// ID of the user or community that owns the audio file. Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="groupId">Community ID, needed when adding the audio file to a community (without minus).</param>
        /// <param name="albumId">Album ID.</param>
        public async Task<int?> Add(int? audioId = null, int? ownerId = null, int? groupId = null,
            int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audioId != null)
                parameters.Add("audio_id", audioId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.add", parameters);
        }

        /// <summary>
        /// Deletes an audio file from a user page or community page.
        /// Docs: <see href="https://vk.com/dev/audio.delete">audio.delete</see>
        /// </summary>
        /// <param name="audioId">Audio file ID.</param>
        /// <param name="ownerId">
        /// ID of the user or community that owns the audio file. Use a negative value to designate a
        /// community ID.
        /// </param>
        public async Task<int> Delete(int? audioId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audioId != null)
                parameters.Add("audio_id", audioId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.delete", parameters);
        }

        /// <summary>
        /// Edits an audio file on a user or community page.;
        /// Docs: <see href="https://vk.com/dev/audio.edit">audio.edit</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the audio file.</param>
        /// <param name="audioId">Audio file ID.</param>
        /// <param name="artist">Name of the artist.</param>
        /// <param name="title">Title of the audio file.</param>
        /// <param name="text">Text of the lyrics of the audio file.</param>
        /// <param name="genreId">Genre of the audio file. See the list of [vk.com/dev/audio_genres|audio genres].</param>
        /// <param name="noSearch">
        /// '1' — audio file will not be available for search; '0' — audio file will be available for
        /// search (default)
        /// </param>
        public async Task<int?> Edit(int? ownerId = null, int? audioId = null, string artist = null,
            string title = null, string text = null, int? genreId = null, bool? noSearch = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (audioId != null)
                parameters.Add("audio_id", audioId.ToApiString());
            if (artist != null)
                parameters.Add("artist", artist);
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (genreId != null)
                parameters.Add("genre_id", genreId.ToApiString());
            if (noSearch != null)
                parameters.Add("no_search", noSearch.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.edit", parameters);
        }

        /// <summary>
        /// Reorders an audio file, placing it between other specified audio files.
        /// Docs: <see href="https://vk.com/dev/audio.reorder">audio.reorder</see>
        /// </summary>
        /// <param name="audioId">Audio file ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the audio file.</param>
        /// <param name="before">ID of the audio file before which to place the audio file.</param>
        /// <param name="after">ID of the audio file after which to place the audio file.</param>
        public async Task<int> Reorder(int? audioId = null, int? ownerId = null, int? before = null,
            int? after = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audioId != null)
                parameters.Add("audio_id", audioId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (before != null)
                parameters.Add("before", before.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.reorder", parameters);
        }

        /// <summary>
        /// Restores a [vk.com/dev/audio.delete|deleted] audio file.
        /// Docs: <see href="https://vk.com/dev/audio.restore">audio.restore</see>
        /// </summary>
        /// <param name="audioId">Audio file ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the audio file.</param>
        public async Task<int> Restore(int? audioId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audioId != null)
                parameters.Add("audio_id", audioId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.restore", parameters);
        }

        /// <summary>
        /// Returns a list of audio albums of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.getAlbums">audio.getAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the audio file.</param>
        /// <param name="offset">Offset needed to return a specific subset of albums.</param>
        /// <param name="count">Number of albums to return.</param>
        public async Task<ApiItemsResponse<AudioAlbum>> GetAlbums(int? ownerId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<AudioAlbum>>("audio.getAlbums", parameters);
        }

        /// <summary>
        /// Creates an empty audio album.
        /// Docs: <see href="https://vk.com/dev/audio.addAlbum">audio.addAlbum</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the album will be created in a community).</param>
        /// <param name="title">Album title.</param>
        public async Task<AddAlbumResponse> AddAlbum(int? groupId = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<AddAlbumResponse>("audio.addAlbum", parameters);
        }

        /// <summary>
        /// Edits the title of an audio album.
        /// Docs: <see href="https://vk.com/dev/audio.editAlbum">audio.editAlbum</see>
        /// </summary>
        /// <param name="groupId">ID of the community where the album is located.;</param>
        /// <param name="albumId">Album ID.</param>
        /// <param name="title">New album title.</param>
        public async Task<int> EditAlbum(int? groupId = null, int? albumId = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int>("audio.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes an audio album.
        /// Docs: <see href="https://vk.com/dev/audio.deleteAlbum">audio.deleteAlbum</see>
        /// </summary>
        /// <param name="groupId">ID of the community where the album is located.;</param>
        /// <param name="albumId">Album ID.</param>
        public async Task<int> DeleteAlbum(int? groupId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.deleteAlbum", parameters);
        }

        /// <summary>
        /// Moves audio files to an album.
        /// Docs: <see href="https://vk.com/dev/audio.moveToAlbum">audio.moveToAlbum</see>
        /// </summary>
        /// <param name="groupId">ID of the community where the audio files are located. By default, current user ID.;</param>
        /// <param name="albumId">ID of the album to which the audio files will be moved.</param>
        /// <param name="audioIds">IDs of the audio files to be moved.; "NOTE: An album can hold up to 1000 audio files.";</param>
        public async Task<int> MoveToAlbum(int? groupId = null, int? albumId = null,
            IEnumerable<int?> audioIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (audioIds != null)
                parameters.Add("audio_ids", audioIds.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.moveToAlbum", parameters);
        }

        /// <summary>
        /// Activates an audio broadcast to the status of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.setBroadcast">audio.setBroadcast</see>
        /// </summary>
        /// <param name="audio">
        /// ID of the audio file to be shown in status (e.g., '1_190442705'). If the parameter is not set, the
        /// audio status of given communities and user will be deleted.
        /// </param>
        /// <param name="targetIds">
        /// IDs of communities and user whose statuses will be included in the broadcast. Use a negative
        /// value to designate a community ID. By default, current user ID.
        /// </param>
        public async Task<IEnumerable<int?>> SetBroadcast(string audio = null, IEnumerable<int?> targetIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (audio != null)
                parameters.Add("audio", audio);
            if (targetIds != null)
                parameters.Add("target_ids", targetIds.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("audio.setBroadcast", parameters);
        }

        /// <summary>
        /// Returns a list of the user's friends and communities that are broadcasting music in their statuses.
        /// Docs: <see href="https://vk.com/dev/audio.getBroadcastList">audio.getBroadcastList</see>
        /// </summary>
        /// <param name="filter">
        /// Types of objects to return:; 'friends' — only friends; 'groups' — only communities; 'all' — both
        /// friends and communities (default)
        /// </param>
        /// <param name="active">
        /// '1' — to return only friends and communities that are broadcasting at the moment.; '0' — to return
        /// all friends and communities (default).
        /// </param>
        public async Task<IEnumerable<UserBroadcast>> GetBroadcastList(string filter = null, bool? active = null)
        {
            var parameters = new Dictionary<string, string>();

            if (filter != null)
                parameters.Add("filter", filter);
            if (active != null)
                parameters.Add("active", active.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<UserBroadcast>>("audio.getBroadcastList", parameters);
        }

        /// <summary>
        /// Returns a list of suggested audio files based on a user's playlist or a particular audio file.
        /// Docs: <see href="https://vk.com/dev/audio.getRecommendations">audio.getRecommendations</see>
        /// </summary>
        /// <param name="targetAudio">
        /// Use to get recommendations based on a particular audio file. The ID of the user or community
        /// that owns an audio file and that audio file's ID, separated by an underscore.;
        /// </param>
        /// <param name="userId">Use to get recommendations based on a user's playlist. User ID. By default, the current user ID.;</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        /// <param name="shuffle">'1' — shuffle on</param>
        public async Task<IEnumerable<AudioFull>> GetRecommendations(string targetAudio = null, int? userId = null,
            int? offset = null, int? count = null, bool? shuffle = null)
        {
            var parameters = new Dictionary<string, string>();

            if (targetAudio != null)
                parameters.Add("target_audio", targetAudio);
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (shuffle != null)
                parameters.Add("shuffle", shuffle.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<AudioFull>>("audio.getRecommendations", parameters);
        }

        /// <summary>
        /// Returns a list of audio files from the "Popular".
        /// Docs: <see href="https://vk.com/dev/audio.getPopular">audio.getPopular</see>
        /// </summary>
        /// <param name="onlyEng">'1' — to return only foreign audio files; '0' — to return all audio files;</param>
        /// <param name="genreId">Genre ID. See the list of [vk.com/dev/audio_genres|audio genres].</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<IEnumerable<AudioFull>> GetPopular(bool? onlyEng = null, int? genreId = null,
            int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (onlyEng != null)
                parameters.Add("only_eng", onlyEng.ToApiString());
            if (genreId != null)
                parameters.Add("genre_id", genreId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<AudioFull>>("audio.getPopular", parameters);
        }

        /// <summary>
        /// Returns the total number of audio files on a user or community page.
        /// Docs: <see href="https://vk.com/dev/audio.getCount">audio.getCount</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the audio files. By default, current user ID.</param>
        public async Task<int?> GetCount(int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.getCount", parameters);
        }
    }
}