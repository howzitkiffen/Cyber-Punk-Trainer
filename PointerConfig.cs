using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Cyber_Punk_Trainer
{
    internal sealed class PointerConfig
    {
        private readonly string configPath;
        private readonly Dictionary<string, string> defaultPointers;
        private readonly Dictionary<string, string> loadedPointers;

        public PointerConfig(string configPath, Dictionary<string, string> defaultPointers)
        {
            this.configPath = configPath;
            this.defaultPointers = new Dictionary<string, string>(defaultPointers, StringComparer.OrdinalIgnoreCase);
            loadedPointers = new Dictionary<string, string>(defaultPointers, StringComparer.OrdinalIgnoreCase);
        }

        public void Initialize()
        {
            if (!File.Exists(configPath))
            {
                WriteDefaultConfig();
                return;
            }

            foreach (string rawLine in File.ReadAllLines(configPath))
            {
                string line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith("#"))
                {
                    continue;
                }

                int separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0 || separatorIndex == line.Length - 1)
                {
                    continue;
                }

                string key = line.Substring(0, separatorIndex).Trim();
                string pointer = line.Substring(separatorIndex + 1).Trim();

                if (key.Length == 0 || pointer.Length == 0)
                {
                    continue;
                }

                loadedPointers[key] = pointer;
            }
        }

        public string GetPointer(string key)
        {
            if (loadedPointers.TryGetValue(key, out string pointer) && !string.IsNullOrWhiteSpace(pointer))
            {
                return pointer;
            }

            if (defaultPointers.TryGetValue(key, out string defaultPointer))
            {
                return defaultPointer;
            }

            throw new KeyNotFoundException($"Pointer key '{key}' was not found in pointer config.");
        }

        private void WriteDefaultConfig()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("# Cyberpunk 2077 Trainer Pointer Config");
            builder.AppendLine("# Update values when game patches move memory addresses.");
            builder.AppendLine("# Format: Key=Cyberpunk2077.exe+baseOffset,offset1,offset2,...");
            builder.AppendLine();

            foreach (KeyValuePair<string, string> pointer in defaultPointers.OrderBy(x => x.Key))
            {
                builder.AppendLine($"{pointer.Key}={pointer.Value}");
            }

            File.WriteAllText(configPath, builder.ToString());
        }
    }
}
