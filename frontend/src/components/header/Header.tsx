import React from 'react';

const Header: React.FC = () => {
  return (
    <header className="bg-success text-white py-3">
      <div className="container">
        <div className="row align-items-center">
          <div className="col-md-4"> {/* Add a column for the logo */}
            {/* You can place your logo here */}
          </div>
          <div className="col-md-8"> {/* Add a column for the links */}
            <nav>
              <ul className="list-unstyled d-flex justify-content-end">
                <li className="mx-3">
                  <a href="#home" className="text-white">Home</a>
                </li>
                <li className="mx-3">
                  <a href="#about" className="text-white">About Us</a>
                </li>
                <li className="mx-3">
                  <a href="#products" className="text-white">Products</a>
                </li>
                <li className="mx-3">
                  <a href="#blog" className="text-white">Blog</a>
                </li>
                <li className="mx-3">
                  <a href="#contact" className="text-white">Contact</a>
                </li>
              </ul>
            </nav>
          </div>
        </div>
      </div>
    </header>
  );
};

export default Header;
