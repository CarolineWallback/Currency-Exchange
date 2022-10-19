import "./App.css";
import React from "react";
import Header from "./components/Header";
import {GetRate} from "./components/FetchRate";

function App() {

  return (
    <div className="App container">
      <Header/>
      <div className="container d-flex justify-content-center">
        <div className="flex-column text-center">
            <button className="btn btn-success" type ="submit" onClick= {() =>{GetRate()}} >Convert to Euro</button>
            <div className="mt-3 text-center" id="exchangeDiv"></div>
            <div className="mt-1 text-center" id="exchangeResultDiv"></div>

            {/* loading-symbol */}
            <div className="hidden text-center" id="hidden">
              <div className="loadingio-spinner-spinner-kb0tc4hwgc"><div className="ldio-7ziqo8sgga2"><div>
              </div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>
            </div>

          </div>
        </div>
      </div>
    </div>
  );
  
}

export default App;

