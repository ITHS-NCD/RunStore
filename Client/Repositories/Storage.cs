using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using Client.Interfaces;

namespace Client.Repositories;

public class Storage<T> : IStorage<T> where T : class
{
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public List<T> Read(string path)
    {
        try
        {
            var storedProducts = File.ReadAllText(path);
            // var data = JsonSerializer.Deserialize<List<T>>(storedProducts, _options);

            // return data && [];
            if (!string.IsNullOrWhiteSpace(storedProducts))
            {
                return JsonSerializer.Deserialize<List<T>>(storedProducts, _options)!;
            }
            else
            {
                return [];
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Write(string path, List<T> data)
    {
        try
        {
            var json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
