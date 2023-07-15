
using System.Text.Json;

namespace Hcms.Domain.Data
{

    /// <summary>
    /// Manager of data settings (connection string)
    /// </summary>
    public static class DataSettingsManager
    {
        private static DataSettings _dataSettings;

        /// <summary>
        /// Load settings
        /// </summary>
        public static DataSettings LoadSettings(bool reloadSettings = false)
        {
            if (!reloadSettings && _dataSettings != null)
                return _dataSettings;

            if (!File.Exists(CommonPath.SettingsPath))
                return new DataSettings();

            try
            {
                var text = File.ReadAllText(CommonPath.SettingsPath);
                _dataSettings = JsonSerializer.Deserialize<DataSettings>(text);
            }
            catch
            {
                //Try to read file
                var connectionString = File.ReadLines(CommonPath.SettingsPath).FirstOrDefault();
                _dataSettings = new DataSettings() { ConnectionString = connectionString, DbProvider = DbProvider.MongoDB };

            }
            return _dataSettings;
        }
    }
}
