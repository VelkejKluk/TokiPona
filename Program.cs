using System.Collections.Concurrent;

Console.WriteLine(@"
 _____  ____  _  __ _    ____  ____  _      ____ 
/__ __\/  _ \/ |/ // \  /  __\/  _ \/ \  /|/  _ \
  / \  | / \||   / | |  |  \/|| / \|| |\ ||| / \|
  | |  | \_/||   \ | |  |  __/| \_/|| | \||| |-||
  \_/  \____/\_|\_\\_/  \_/   \____/\_/  \|\_/ \|
                                                 
");

//dictionary
Dictionary<string, string> slovnik = new Dictionary<string, string>()
{
    { "a", "ano" },
    { "akesi", "nehezké zvíře/plaz/obojživelník" },
    { "alasa", "lovit/píce" },
    { "ali", "všechno/hojný/nepočitatelný/bohatý/každý/život/vesmír/100" },
    { "anpa", "klanět se/dolů/pokořit/pokorný/závislý" },
    { "ante", "jiný/změněný" },
    { "anu", "nebo" },
    { "awen", "trvalý/zachováno/chráněný/bezpečný/čekající/pokračovat" },
    { "e", "předložka" },
    { "en", "spojka" },
    { "esun", "obchod/bazar/obchodní transakce" },
    { "ijo", "věc/jev/objekt/hmota" },
    { "ike", "špatný/negativní/irelevantní/nepodstatný" },
    { "ilo", "nástroj/nářadí/mašina/zařízení" },
    { "", "" }s,

};

foreach (var item in slovnik)
{
    Console.WriteLine(item.Key + "-----" + item.Value);
}

