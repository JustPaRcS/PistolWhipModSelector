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
    class PistolWhipModSettings
    {
        public string MainSettingsFolderPath { get; private set; }
        public string MainSettingsPath { get; private set; }
        private XmlDocument xmlDoc;

        public PistolWhipModSettings()
        {
            MainSettingsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PistolWhipCustomMod_PaRcS";
            MainSettingsPath = this.MainSettingsFolderPath + @"\PistolWhipModSettings.xml";

            this.CheckMainSettingsFolderExist();
            this.CheckMainSettingsExist();

            this.LoadXmlDoc();
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
            xmlDoc = new XmlDocument();
            XmlNode xmlNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlNode);

            XmlNode rootNode = xmlDoc.CreateElement("PistolWhipModSettings");
            xmlDoc.AppendChild(rootNode);

            //-------------------------------------------------------------------------------------------

            XmlNode infoNode = xmlDoc.CreateElement("info");
            rootNode.AppendChild(infoNode);

            XmlNode node = xmlDoc.CreateElement("version");
            node.InnerText = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            infoNode.AppendChild(node);

            node = xmlDoc.CreateElement("firstInstalledDate");
            XmlAttribute attribute = xmlDoc.CreateAttribute("timezone");
            attribute.Value = "UTC";
            node.Attributes.Append(attribute);
            node.InnerText = DateTime.UtcNow.ToString();
            infoNode.AppendChild(node);

            node = xmlDoc.CreateElement("lastChangeDate");
            attribute = xmlDoc.CreateAttribute("timezone");
            attribute.Value = "UTC";
            node.Attributes.Append(attribute);
            node.InnerText = DateTime.UtcNow.ToString();
            infoNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            XmlNode creatorNode = xmlDoc.CreateElement("creator");
            rootNode.AppendChild(creatorNode);

            node = xmlDoc.CreateElement("name");
            node.InnerText = "PaRcS";
            creatorNode.AppendChild(node);

            node = xmlDoc.CreateElement("discord");
            node.InnerText = "PaRcS#2179";
            creatorNode.AppendChild(node);

            node = xmlDoc.CreateElement("github");
            node.InnerText = "github.com/JustPaRcS";
            creatorNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            XmlNode settingsNode = xmlDoc.CreateElement("settings");
            rootNode.AppendChild(settingsNode);

            node = xmlDoc.CreateElement("gameFolderPath");
            node.InnerText = "";
            settingsNode.AppendChild(node);

            //-------------------------------------------------------------------------------------------

            this.SaveXmlDoc();
        }

        private void LoadXmlDoc()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(this.MainSettingsPath);
        }
        private void SaveXmlDoc()
        {
            XmlNode node = xmlDoc.SelectSingleNode("//PistolWhipModSettings/info/lastChangeDate");
            node.InnerText = DateTime.UtcNow.ToString();

            xmlDoc.Save(this.MainSettingsPath);
        }

        public void SetGameFolderPath(string path)
        {
            XmlNode node = xmlDoc.SelectSingleNode("//PistolWhipModSettings/settings/gameFolderPath");
            node.InnerText = path;

            this.SaveXmlDoc();
        }

        public string GetGameFolderPath()
        {
            XmlNode node = xmlDoc.SelectSingleNode("//PistolWhipModSettings/settings/gameFolderPath");
            return node.InnerText;
        }
    }
}
