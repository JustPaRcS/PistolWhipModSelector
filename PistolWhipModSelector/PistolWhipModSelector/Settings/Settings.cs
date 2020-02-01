using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PistolWhipModSelector.Settings
{
    class Settings
    {
        public string MainSettingsFolderPath { get; private set; }
        public string MainSettingsPath { get; private set; }


        public Settings()
        {
            MainSettingsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PistolWhipCustomMod_PaRcS";
            MainSettingsPath = this.MainSettingsFolderPath + @"\PistolWhipModSettings.xml";

            this.CheckMainSettingsFolderExist();
            this.CheckMainSettingsExist();
        }

        private void CheckMainSettingsFolderExist()
        {
            if (!Directory.Exists(this.MainSettingsFolderPath))
            {
                this.CreateMainSettingsFolder();
            }
        }

        private void CreateMainSettingsFolder()
        {
            try
            {
                Directory.CreateDirectory(this.MainSettingsFolderPath);
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed to create settings folder!");
                Application.Exit();
            }
        }

        private void CheckMainSettingsExist()
        {
            if(!File.Exists(this.MainSettingsFolderPath + @"\PistolWhipModSettings.xml"))
            {
                this.CreateMainSettings();
            }
        }

        private void CreateMainSettings()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode xmlNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlNode);

            XmlNode rootNode = doc.CreateElement("PistolWhipModSettings");
            doc.AppendChild(rootNode);

            //-------------------------------------------------------------------------------------------

            XmlNode infoNode = doc.CreateElement("info");
            rootNode.AppendChild(infoNode);

            XmlNode node = doc.CreateElement("version");
            node.InnerText = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            infoNode.AppendChild(node);

            node = doc.CreateElement("firstInstalledDate");
            XmlAttribute attribute = doc.CreateAttribute("timezone");
            attribute.Value = "UTC";
            node.Attributes.Append(attribute);
            node.InnerText = DateTime.UtcNow.ToString();
            infoNode.AppendChild(node);

            node = doc.CreateElement("lastChangeDate");
            attribute = doc.CreateAttribute("timezone");
            attribute.Value = "UTC";
            node.Attributes.Append(attribute);
            node.InnerText = DateTime.UtcNow.ToString();
            infoNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            XmlNode creatorNode = doc.CreateElement("creator");
            rootNode.AppendChild(creatorNode);

            node = doc.CreateElement("name");
            node.InnerText = "PaRcS";
            creatorNode.AppendChild(node);

            node = doc.CreateElement("discord");
            node.InnerText = "PaRcS#2179";
            creatorNode.AppendChild(node);

            node = doc.CreateElement("github");
            node.InnerText = "github.com/JustPaRcS";
            creatorNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            XmlNode settingsNode = doc.CreateElement("settings");
            rootNode.AppendChild(settingsNode);

            node = doc.CreateElement("gameFolderPath");
            node.InnerText = "";
            settingsNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            doc.Save(this.MainSettingsPath);
        }
    }
}
