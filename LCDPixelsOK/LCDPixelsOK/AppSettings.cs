// <copyright file="AppSettings.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text.Json;
    using System.Windows.Forms;

    /// <summary>
    /// The App Settings class.
    /// </summary>
    internal class AppSettings
    {
        /// <summary>
        /// Gets or sets the value of the color index setting.
        /// </summary>
        public int ColorIndex { get; set; }

        /// <summary>
        /// Gets or sets the value of the custom color setting.
        /// </summary>
        public int CustomColor { get; set; }

        /// <summary>
        /// Gets the default settings file. Handles portable and installable scenarios.
        /// </summary>
        private static string DefaultSettingsFilePath
        {
            get
            {
                string path = Path.ChangeExtension(Application.ExecutablePath, ".settings.json");

                if (!File.Exists(path))
                {
                    path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        Application.CompanyName,
                        Application.ProductName,
                        Path.GetFileName(path));
                }

                System.Diagnostics.Debug.WriteLine(path);
                return path;
            }
        }

        /// <summary>
        /// Loads the app settings from the default settings file.
        /// </summary>
        /// <returns>An AppSettings instance with the loaded values.</returns>
        public static AppSettings Load()
        {
            try
            {
                return JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(DefaultSettingsFilePath));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return new AppSettings();
            }
        }

        /// <summary>
        /// Saves the app settings to the default settings file.
        /// </summary>
        public void Save()
        {
            try
            {
                File.WriteAllText(DefaultSettingsFilePath, JsonSerializer.Serialize(this));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
