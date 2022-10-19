
import axios from "axios";

export async function GetRate(){
    
    document.getElementById("exchangeDiv").innerHTML=""
    document.getElementById("exchangeResultDiv").innerHTML = "";
    document.getElementById("hidden").classList.remove("hidden");
    
    const response = await axios.get('https://localhost:7140/api/exchange');

    if(response.data != null)
    {
        document.getElementById("hidden").classList.add("hidden");
        document.getElementById("exchangeDiv").innerHTML="100 SEK to EUR:"
        document.getElementById("exchangeResultDiv").innerHTML = response.data * 100;
    }
    
};

    

    
