using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Audio API section.
    /// </summary>
    public class Audio
    {
        private Vkontakte _vkontakte;

        internal Audio(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of audio files of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.get">audio.get</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the audio file. Use a negative value to designate a community ID.</param>
        /// <param name="album_id">Audio album ID.</param>
        /// <param name="audio_ids">IDs of the audio files to return.</param>
        /// <param name="need_user">'1' — to return information about users who uploaded audio files</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Audio.AudioFull>> Get(int? owner_id = null, int? album_id = null, IEnumerable<int?> audio_ids = null, bool? need_user = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (audio_ids != null)
                parameters.Add("audio_ids", audio_ids.ToApiString());
            if (need_user != null)
                parameters.Add("need_user", need_user.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Audio.AudioFull>>("audio.get", parameters);
        }

        /// <summary>
        /// Returns information about audio files by their IDs.
        /// Docs: <see href="https://vk.com/dev/audio.getById">audio.getById</see>
        /// </summary>
        /// <param name="audios">Audio file IDs, in the following format:; "{owner_id}_{audio_id}"</param>
        public async Task<IEnumerable<VkLib.Types.Audio.AudioFull>> GetById(IEnumerable<string> audios = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audios != null)
                parameters.Add("audios", audios.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Audio.AudioFull>>("audio.getById", parameters);
        }

        /// <summary>
        /// Returns lyrics associated with an audio file.
        /// Docs: <see href="https://vk.com/dev/audio.getLyrics">audio.getLyrics</see>
        /// </summary>
        /// <param name="lyrics_id">Lyrics ID (could be obtained with [vk.com/dev/audio.get|audio.get], [vk.com/dev/audio.getById|audio.getById], or [vk.com/dev/audio.search|audio.search] methods).</param>
        public async Task<VkLib.Types.Audio.Lyrics> GetLyrics(int? lyrics_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (lyrics_id != null)
                parameters.Add("lyrics_id", lyrics_id.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Audio.Lyrics>("audio.getLyrics", parameters);
        }

        /// <summary>
        /// Returns a list of audio matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/audio.search">audio.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'The Beatles').</param>
        /// <param name="auto_complete">'1' — to correct for mistakes in the search query (e.g., if you enter 'Beetles', the system will search for 'Beatles').</param>
        /// <param name="lyrics">'1' — to return only audio files that have associated lyrics.</param>
        /// <param name="performer_only">'1' — to search only by artist name.</param>
        /// <param name="sort">Sort order: ; '1' — by duration;; '2' — by popularity;; '0' — by date added.</param>
        /// <param name="search_own">'1' — to search among current user's audios. By default: '0'.</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Audio.AudioFull>> Search(string q = null, bool? auto_complete = null, bool? lyrics = null, bool? performer_only = null, int? sort = null, bool? search_own = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (auto_complete != null)
                parameters.Add("auto_complete", auto_complete.ToApiString());
            if (lyrics != null)
                parameters.Add("lyrics", lyrics.ToApiString());
            if (performer_only != null)
                parameters.Add("performer_only", performer_only.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (search_own != null)
                parameters.Add("search_own", search_own.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Audio.AudioFull>>("audio.search", parameters);
        }

        /// <summary>
        /// Returns the server address to [vk.com/dev/upload_files_2|upload audio files].
        /// Docs: <see href="https://vk.com/dev/audio.getUploadServer">audio.getUploadServer</see>
        /// </summary>
        public async Task<VkLib.Responses.Audio.GetUploadServerResponse> GetUploadServer()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<VkLib.Responses.Audio.GetUploadServerResponse>("audio.getUploadServer", parameters);
        }

        /// <summary>
        /// Saves audio files after successful [vk.com/dev/upload_files_2|uploading].
        /// Docs: <see href="https://vk.com/dev/audio.save">audio.save</see>
        /// </summary>
        /// <param name="server">This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the server].</param>
        /// <param name="audio">This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the server].</param>
        /// <param name="hash">This parameter is returned when the audio file is [vk.com/dev/upload_files_2|uploaded to the server].</param>
        /// <param name="artist">The name of the artist. By default, this is obtained from ID3 tags.</param>
        /// <param name="title">The title of the audio file. By default, this is obtained from ID3 tags.</param>
        public async Task<IEnumerable<VkLib.Types.Audio.Audio>> Save(int? server = null, string audio = null, string hash = null, string artist = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

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

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Audio.Audio>>("audio.save", parameters);
        }

        /// <summary>
        /// Copies an audio file to a user page or community page.
        /// Docs: <see href="https://vk.com/dev/audio.add">audio.add</see>
        /// </summary>
        /// <param name="audio_id">Audio file ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the audio file. Use a negative value to designate a community ID. ; ;</param>
        /// <param name="group_id">Community ID, needed when adding the audio file to a community (without minus).</param>
        /// <param name="album_id">Album ID.</param>
        public async Task<int?> Add(int? audio_id = null, int? owner_id = null, int? group_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audio_id != null)
                parameters.Add("audio_id", audio_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.add", parameters);
        }

        /// <summary>
        /// Deletes an audio file from a user page or community page.
        /// Docs: <see href="https://vk.com/dev/audio.delete">audio.delete</see>
        /// </summary>
        /// <param name="audio_id">Audio file ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the audio file. Use a negative value to designate a community ID.</param>
        public async Task<int> Delete(int? audio_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audio_id != null)
                parameters.Add("audio_id", audio_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.delete", parameters);
        }

        /// <summary>
        /// Edits an audio file on a user or community page.;
        /// Docs: <see href="https://vk.com/dev/audio.edit">audio.edit</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the audio file.</param>
        /// <param name="audio_id">Audio file ID.</param>
        /// <param name="artist">Name of the artist.</param>
        /// <param name="title">Title of the audio file.</param>
        /// <param name="text">Text of the lyrics of the audio file.</param>
        /// <param name="genre_id">Genre of the audio file. See the list of [vk.com/dev/audio_genres|audio genres].</param>
        /// <param name="no_search">'1' — audio file will not be available for search; '0' — audio file will be available for search (default)</param>
        public async Task<int?> Edit(int? owner_id = null, int? audio_id = null, string artist = null, string title = null, string text = null, int? genre_id = null, bool? no_search = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (audio_id != null)
                parameters.Add("audio_id", audio_id.ToApiString());
            if (artist != null)
                parameters.Add("artist", artist);
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (genre_id != null)
                parameters.Add("genre_id", genre_id.ToApiString());
            if (no_search != null)
                parameters.Add("no_search", no_search.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.edit", parameters);
        }

        /// <summary>
        /// Reorders an audio file, placing it between other specified audio files.
        /// Docs: <see href="https://vk.com/dev/audio.reorder">audio.reorder</see>
        /// </summary>
        /// <param name="audio_id">Audio file ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the audio file.</param>
        /// <param name="before">ID of the audio file before which to place the audio file.</param>
        /// <param name="after">ID of the audio file after which to place the audio file.</param>
        public async Task<int> Reorder(int? audio_id = null, int? owner_id = null, int? before = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audio_id != null)
                parameters.Add("audio_id", audio_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
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
        /// <param name="audio_id">Audio file ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the audio file.</param>
        public async Task<int> Restore(int? audio_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audio_id != null)
                parameters.Add("audio_id", audio_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.restore", parameters);
        }

        /// <summary>
        /// Returns a list of audio albums of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.getAlbums">audio.getAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the audio file.</param>
        /// <param name="offset">Offset needed to return a specific subset of albums.</param>
        /// <param name="count">Number of albums to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Audio.AudioAlbum>> GetAlbums(int? owner_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Audio.AudioAlbum>>("audio.getAlbums", parameters);
        }

        /// <summary>
        /// Creates an empty audio album.
        /// Docs: <see href="https://vk.com/dev/audio.addAlbum">audio.addAlbum</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the album will be created in a community).</param>
        /// <param name="title">Album title.</param>
        public async Task<VkLib.Responses.Audio.AddAlbumResponse> AddAlbum(int? group_id = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<VkLib.Responses.Audio.AddAlbumResponse>("audio.addAlbum", parameters);
        }

        /// <summary>
        /// Edits the title of an audio album.
        /// Docs: <see href="https://vk.com/dev/audio.editAlbum">audio.editAlbum</see>
        /// </summary>
        /// <param name="group_id">ID of the community where the album is located.;</param>
        /// <param name="album_id">Album ID.</param>
        /// <param name="title">New album title.</param>
        public async Task<int> EditAlbum(int? group_id = null, int? album_id = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int>("audio.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes an audio album.
        /// Docs: <see href="https://vk.com/dev/audio.deleteAlbum">audio.deleteAlbum</see>
        /// </summary>
        /// <param name="group_id">ID of the community where the album is located.;</param>
        /// <param name="album_id">Album ID.</param>
        public async Task<int> DeleteAlbum(int? group_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.deleteAlbum", parameters);
        }

        /// <summary>
        /// Moves audio files to an album.
        /// Docs: <see href="https://vk.com/dev/audio.moveToAlbum">audio.moveToAlbum</see>
        /// </summary>
        /// <param name="group_id">ID of the community where the audio files are located. By default, current user ID.;</param>
        /// <param name="album_id">ID of the album to which the audio files will be moved.</param>
        /// <param name="audio_ids">IDs of the audio files to be moved.; "NOTE: An album can hold up to 1000 audio files.";</param>
        public async Task<int> MoveToAlbum(int? group_id = null, int? album_id = null, IEnumerable<int?> audio_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (audio_ids != null)
                parameters.Add("audio_ids", audio_ids.ToApiString());

            return await _vkontakte.GetAsync<int>("audio.moveToAlbum", parameters);
        }

        /// <summary>
        /// Activates an audio broadcast to the status of a user or community.
        /// Docs: <see href="https://vk.com/dev/audio.setBroadcast">audio.setBroadcast</see>
        /// </summary>
        /// <param name="audio">ID of the audio file to be shown in status (e.g., '1_190442705'). If the parameter is not set, the audio status of given communities and user will be deleted.</param>
        /// <param name="target_ids">IDs of communities and user whose statuses will be included in the broadcast. Use a negative value to designate a community ID. By default, current user ID.</param>
        public async Task<IEnumerable<int?>> SetBroadcast(string audio = null, IEnumerable<int?> target_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (audio != null)
                parameters.Add("audio", audio);
            if (target_ids != null)
                parameters.Add("target_ids", target_ids.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("audio.setBroadcast", parameters);
        }

        /// <summary>
        /// Returns a list of the user's friends and communities that are broadcasting music in their statuses.
        /// Docs: <see href="https://vk.com/dev/audio.getBroadcastList">audio.getBroadcastList</see>
        /// </summary>
        /// <param name="filter">Types of objects to return:; 'friends' — only friends; 'groups' — only communities; 'all' — both friends and communities (default)</param>
        /// <param name="active">'1' — to return only friends and communities that are broadcasting at the moment.; '0' — to return all friends and communities (default).</param>
        public async Task<IEnumerable<VkLib.Types.Users.UserBroadcast>> GetBroadcastList(string filter = null, bool? active = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (filter != null)
                parameters.Add("filter", filter);
            if (active != null)
                parameters.Add("active", active.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Users.UserBroadcast>>("audio.getBroadcastList", parameters);
        }

        /// <summary>
        /// Returns a list of suggested audio files based on a user's playlist or a particular audio file.
        /// Docs: <see href="https://vk.com/dev/audio.getRecommendations">audio.getRecommendations</see>
        /// </summary>
        /// <param name="target_audio">Use to get recommendations based on a particular audio file. The ID of the user or community that owns an audio file and that audio file's ID, separated by an underscore.;</param>
        /// <param name="user_id">Use to get recommendations based on a user's playlist. User ID. By default, the current user ID.;</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        /// <param name="shuffle">'1' — shuffle on</param>
        public async Task<IEnumerable<VkLib.Types.Audio.AudioFull>> GetRecommendations(string target_audio = null, int? user_id = null, int? offset = null, int? count = null, bool? shuffle = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_audio != null)
                parameters.Add("target_audio", target_audio);
            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (shuffle != null)
                parameters.Add("shuffle", shuffle.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Audio.AudioFull>>("audio.getRecommendations", parameters);
        }

        /// <summary>
        /// Returns a list of audio files from the "Popular".
        /// Docs: <see href="https://vk.com/dev/audio.getPopular">audio.getPopular</see>
        /// </summary>
        /// <param name="only_eng">'1' — to return only foreign audio files; '0' — to return all audio files;</param>
        /// <param name="genre_id">Genre ID. See the list of [vk.com/dev/audio_genres|audio genres].</param>
        /// <param name="offset">Offset needed to return a specific subset of audio files.</param>
        /// <param name="count">Number of audio files to return.</param>
        public async Task<IEnumerable<VkLib.Types.Audio.AudioFull>> GetPopular(bool? only_eng = null, int? genre_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (only_eng != null)
                parameters.Add("only_eng", only_eng.ToApiString());
            if (genre_id != null)
                parameters.Add("genre_id", genre_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Audio.AudioFull>>("audio.getPopular", parameters);
        }

        /// <summary>
        /// Returns the total number of audio files on a user or community page.
        /// Docs: <see href="https://vk.com/dev/audio.getCount">audio.getCount</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the audio files. By default, current user ID.</param>
        public async Task<int?> GetCount(int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());

            return await _vkontakte.GetAsync<int?>("audio.getCount", parameters);
        }

    }
}
