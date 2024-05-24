class Prorgram{
    static void Main(){
        // File name
        string fileName = "../file.txt";

        FileManager fm = new();
        fm.Write(fileName, "Aku ingin liburan");
    }
}
class FileManager {
    public void Write(string path, string message) {
        using (StreamWriter stream = new(path)){
            stream.WriteLine(message);
            // stream.Dispose(); // Automatically disposed whether there is exception or not.
        }
    }
    public string ReadLine(string path) {
        string result;
        using (StreamReader stream = new(path)){
            result = stream.ReadLine();
            // stream.Dispose(); // Automatically disposed when involve "using"
        }
        return result;
    }
}