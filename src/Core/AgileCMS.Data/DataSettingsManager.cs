
using System.Text.Json;

namespace AgileCMS.Domain.Data
{

    /// <summary>
    /// Manage connection string (Load from /ِDatabaseSettings.cfg)
    /// We Won't store connection str to appsettings.json because of
    /// we need to writable file that created aumaticly during installation (Settings.cfg)
    /// we need one instanse of this class in whole the application so make it static
    /// </summary>
    public static class DataSettingsManager
    {
        private static DataSettings _dataSettings;

        private static bool? _databaseIsInstalled;


        /// <summary>
        /// Load settings from DatabaseSettings.cfg
        /// </summary>
        public static DataSettings LoadSettings()
        {
            if ( _dataSettings != null)
                return _dataSettings;

            // TODO: Move Path and file name to a static constant
            string settingFilePath = "/App_Data/ِDatabaseSettings.cfg";
            if (!File.Exists(settingFilePath)) return new DataSettings();

            try
            {
                var text = File.ReadAllText(settingFilePath);
                //Map settings
                _dataSettings = JsonSerializer.Deserialize<DataSettings>(text);
            }
            catch (Exception ex)
            {
                // TODO: Create default connection string on exception
            }
            return _dataSettings;
        }
    }
}
