import React from 'react';
import Logo from "../../assets/logo1.jpg";



const Banner: React.FC = () => {
  return (
    <section id="home" className="bg-success text-white py-5">
      <div className="container">
        <div className="row justify-content-center"> {/* Center the content */}
          <div className="col-md-8 text-center"> {/* Add a column for the banner content */}
            <img
              src={Logo}
              alt="Eco Farmer Banner"
              className="img-fluid mb-4"
            />
            <h1>Welcome to Eco Farmer</h1>
            <p>Your source for organic food and sustainable products.</p>
            <button className="btn btn-light btn-lg">Shop Now</button>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Banner;
