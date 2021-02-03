// <copyright file="AppSettings.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text.Json;
    using System.Windows.Forms;

    class AppSettings
    {
        //private AppSettings()
        //{
        //    this.ColorIndex = 0;
        //    this.CustomColor = Color.Orange;
        //}

        public int ColorIndex { get; set; }

        public int CustomColor { get; set; }

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
