using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class LitJsonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Book> books = new List<Book>();
        books.Add(new Book(12, "Unity入门到入土", "贝利亚"));
        books.Add(new Book(512, "Unity start to end", "JieDe"));
        string jsonInfo = JsonMapper.ToJson(books);
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }
        File.WriteAllText(Application.streamingAssetsPath+ "/"+"Testjson.json", jsonInfo);

    }
}
public class Book
{
    public int id;
    public string name, author;

    public Book(int id, string name, string author)
    {
        this.id = id;
        this.name = name;
        this.author = author;
    }
}