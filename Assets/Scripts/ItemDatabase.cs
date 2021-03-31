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
                }),
                new Item(52, "Tagebucheintrag #1", "Am 4. August 1944 bewerfen deutsche und ukrainische Soldaten Stefania Jadwiga Włodarczyks Haus mit Granaten. »Ich erinnere mich, dass wir nicht aus dem Haus gehen konnten, weil draußen geschossen wurde. Danach befahlen uns die Deutschen (meine Familie bestand zu dem Zeitpunkt aus meinen Eltern und fünf Kindern zwischen sieben Monaten und 13 Jahren) und allen anderen Hausbewohnern, das Haus zu verlassen und sich im Hof zu versammeln. Wir durften keinerlei Sachen aus der Wohnung mitnehmen. Als alle draußen waren, wurde unser Haus angezündet. So wie ich da stand, gekleidet nur in mein Sommerkleid, trieben uns die Deutschen zum Warschauer Westbahnhof. Wer das Tempo nicht mithalten konnte, wurde auf der Stelle erschossen.«",
                new Dictionary<string, int>
                {
                    {"Stefania Jadwiga Włodarczyk", 2007}
                }),
                new Item(53, "Tagebucheintrag #17", "»Sie brachten uns zum Bahnhof und verluden uns in einen Güterzug Richtung Brenner. Wir verbrachten die Nacht einer auf dem anderen liegend. (…) Man wusste nicht, wohin man kam. (…) Ab und zu ein Halt. Scharfe Bremsungen durch die extreme Länge des Konvois. (…) Nachts konnten wir kaum schlafen. Durcheinander der Rucksäcke und verschiedenster Dinge, Kameraden (…), die immer wütend herumschrien. Wir wechselten uns dabei ab, mit baumelnden Beinen an den Seitenöffnungen des Waggons zu sitzen.«",
                new Dictionary<string, int>
                {
                    {"Giuseppe Chiampo", 1943}
                }),
                new Item(54, "Tagebucheintrag #25", "»So ungefähr 70 Personen waren im Waggon. Und zwei Eimer, und in einem war Wasser und das andere war das WC. So 70, 80 Personen ungefähr, alte, junge. Und so kleines Fenster ist gewesen. Sehr eng, sehr eng. Und der Weg dauert zweiundhalb Tage. Und wir wussten nicht, (…) wohin werden wir fahren.«",
                new Dictionary<string, int>
                {
                    {"Katalin Forgács", 2008}
                }),
                new Item(55, "Tagebucheintrag #38", "Zwangsarbeitende bei der Reichsbahn litten meistens unter schlechten Arbeitsbedingungen. Für die harte körperliche Arbeit bei oft weiten Arbeitswegen gab es selten genug zu essen. [...] Ausbesserungswerke waren in den Kriegsjahren von zentraler Bedeutung innerhalb des Reichsbahn-Apparats. Daher erhielten sie bevorzugt Arbeitskräfte zugewiesen.",
                new Dictionary<string, int>
                {
                    {"Text der Ausstellung 'Zwangsarbeit in Niedersachsen'", 2015}
                }),
                new Item(56, "Tagebucheintrag #39", "Der Arbeitsdruck im RAW Göttingen war sehr hoch – schon für die deutschen Beschäftigten galt eine 63-Stunden-Woche bei Sonntagsarbeit und totaler Urlaubssperre – und die Arbeit sehr schwer: Eine [...] Kolonne reinigte die stark verschmutzte Lokunterseite mittels einer giftigen Mischung aus sehr heißem Wasser und Sodalösung. Dieses »scharfe Wasser« verätzte die Hände und beim Einatmen auch die Lungen. Eine dritte Kolonne musste unter hohem Arbeitsdruck entlang der durch die Halle wandernden Lok den Zusammenbau vornehmen. Aufgrund dieser hektischen und giftigen Arbeit, ungenügender Beleuchtung, fehlender Schutzbekleidung, Unterernährung und zunehmender körperlicher Erschöpfung kam es zu Verletzungen und schweren Unfällen.",
                new Dictionary<string, int>
                {
                    {"Text der Ausstellung 'Zwangsarbeit in Niedersachsen'", 2015}
                })
        };
    }
}
