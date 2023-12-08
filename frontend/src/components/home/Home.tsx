import React from 'react';
import Header from '../header/Header';
import Banner from '../banner/Banner';
import AboutUs from '../about/AboutUs';
import FeaturedProducts from '../products/FeaturedProducts';
import BlogSection from '../blog/BlogSection';
import Testimonials from '../testimonials/Testimonials';
import Contact from '../contact/Contact';

const Home: React.FC = () => {
  return (
    <div>
      {/* Header section */}
      <div className="bg-black text-white py-3">
        <div className="container">
          <Header />
        </div>
      </div>

      {/* Banner section */}
      <div className="container mt-4">
        <Banner />
      </div>

      {/* AboutUs section */}
      <div className="container mt-4">
        <AboutUs />
      </div>

      {/* FeaturedProducts section */}
      <div className="container mt-4">
        <FeaturedProducts />
      </div>

      {/* BlogSection section */}
      <div className="container mt-4">
        <BlogSection />
      </div>

      {/* Testimonials section */}
      <div className="container mt-4">
        <Testimonials />
      </div>

      {/* Contact section */}
      <div className="container mt-4">
        <Contact />
      </div>
    </div>
  );
};

export default Home;
