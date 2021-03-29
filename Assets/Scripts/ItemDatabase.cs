using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    public List<Item> items = new List<Item>();

    //Build item database on startup
    private void Awake()
    {
        BuildDatabase();
    }

    //Find item with ID
    public Item GetItem(int id)
    {
        return items.Find(items => items.id == id);
    }

    //Find item with name
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    //Item database
    void BuildDatabase()
    {
        items = new List<Item>() {
                new Item(0, "Spitzhacke", "Wurde oft an Zwangsarbeiter in Steinbrüchen oder zur Beseitigung von Trümmern ausgeteilt.\n\nAnscheinend hat eine Wache vergessen dieses Exemplar wieder einzusammeln.",
                new Dictionary<string, int>
                {
                    {"Haltbarkeit", 10}
                }),
                new Item(1, "Schaufel", "Ein Werkzeug, welches nach einem großflächigen Bombardement der Alliierten an Zwangsarbeiter verteilt wurde, um die Trümmer zu beseitigen.\n\nKönnte auf die eine oder andere Weise hilfreich sein.",
                new Dictionary<string, int>
                {
                    {"Haltbarkeit", 10}
                }),
                new Item(2, "Erdbeere", "Kann gegen den ständigen Hunger gegessen werden.",
                new Dictionary<string, int>
                {
                    {"Hungergefühl", -1},
                    {"Energie", 1}
                }),
                new Item(3, "Brot", "Eine Scheibe Brot - die spärliche Ration für Zwangsarbeiter umfasste lediglich 4 Scheiben pro Tag.",
                new Dictionary<string, int>
                {
                    {"Hungergefühl", -2},
                    {"Gesundheit", 1},
                    {"Menge", 4}
                }),
                new Item(4, "Kartoffel", "Eine faulige Kartoffel - immer noch besser als zu verhungern.",
                new Dictionary<string, int>
                {
                    {"Hungergefühl", -1},
                }),
                new Item(5, "Zucker", "Ein Stück Würfelzucker - gibt viel Energie.",
                new Dictionary<string, int>
                {
                    {"Energie", 5}
                }),
                new Item(6, "Zigaretten", "Ein paar Zigaretten - eines der wenigen 'Luxusgüter', zu dem Zwangsarbeiter bedingt Zugang hatten.\n\nDient als Währung für den Tauschhandel mit anderen Zwangsarbeitern.",
                new Dictionary<string, int>
                {
                    {"Menge", 8}
                }),
                new Item(7, "Zange", "Eine Zange - wurde anscheinend von einem Arbeitsplatz entwendet.\n\nKann zum schneiden von Draht verwendet werden.",
                new Dictionary<string, int>
                {
                    {"Haltbarkeit", 10}
                }),
                new Item(50, "Tagebucheintrag #43", "»Arbeitslohn haben wir nicht bekommen. Zum Essen haben wir fast immer Suppe aus der Steckrübe bekommen, ab und zu gab es Nudeln, Kartoffeln, nur an Wochenenden Bouletten aus Leber. (...) Wir hatten ständig Hunger (...).«",
                new Dictionary<string, int>
                {
                    {"Roman Kornijenko", 1944}
                }),
                new Item(51, "Tagebucheintrag #29", "»Nach der erschöpfenden Arbeit und dem ständigen Hunger blieben keine Kräfte für Spaziergänge. (…) Ich habe an Flucht gedacht, aber es gab keine Möglichkeit. Ein Mensch, der körperlich und geistig erschöpft war, weiter als ins KZ wäre er nicht gekommen.«",
                new Dictionary<string, int>
                {
                    {"Roman Kornijenko", 1944}
                })
        };
    }
}
