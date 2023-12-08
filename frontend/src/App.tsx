import "bootstrap/dist/css/bootstrap.min.css";
import Home from "./components/home/Home.tsx"; // Import the Home component

import "./App.css";
import Logo from "./assets/logo1.jpg";

function App() {
  return (
    <>
      <div></div>
      <h1>ECO FARMER</h1>
      <div className="logo">
       

       
      </div>
      {/* Render the Home component */}
      <Home />
    </>
  );
}

export default App;
