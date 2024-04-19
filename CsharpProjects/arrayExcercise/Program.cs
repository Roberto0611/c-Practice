string[] keys = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string key in keys){
    if(key.StartsWith('B')){
        Console.WriteLine(key);
    }
}