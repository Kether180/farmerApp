// Home.tsx
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
      <Header />
      <Banner />
      <AboutUs />
      <FeaturedProducts />
      <BlogSection />
      <Testimonials />
      <Contact />
    </div>
  );
};

export default Home;
