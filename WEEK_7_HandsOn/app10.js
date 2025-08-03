// src/OfficeList.js
import React from 'react';

const OfficeList = () => {
  // Image URL (can replace with your own if needed)
  const officeImage = "/office_desk.jpg"; 


  // Single object example
  const featuredOffice = {
    name: "Skyline Workspace",
    rent: 55000,
    address: "14th Floor, Orion Tower, Mumbai"
  };

  // List of offices
  const officeSpaces = [
    {
      name: "GreenTech Hub",
      rent: 45000,
      address: "Sector 62, Noida"
    },
    {
      name: "WorkNest",
      rent: 65000,
      address: "Indiranagar, Bangalore"
    },
    {
      name: "HiveSpace",
      rent: 72000,
      address: "Gachibowli, Hyderabad"
    }
  ];

  return (
    <div>
      {/* Heading using JSX */}
      <h1>🏢 Office Space Rental App</h1>

      {/* Image attribute using JSX */}
      <img src={officeImage} alt="Office Space" style={{ width: "300px", height: "150px" }} />


      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {featuredOffice.name}</p>
      <p><strong>Address:</strong> {featuredOffice.address}</p>
      <p>
        <strong>Rent:</strong>{' '}
        <span style={{ color: featuredOffice.rent < 60000 ? 'red' : 'green' }}>
          ₹{featuredOffice.rent}
        </span>
      </p>

      <h2>Other Office Spaces</h2>
      <ul>
        {officeSpaces.map((office, index) => (
          <li key={index} style={{ marginBottom: '15px' }}>
            <p><strong>Name:</strong> {office.name}</p>
            <p><strong>Address:</strong> {office.address}</p>
            <p>
              <strong>Rent:</strong>{' '}
              <span style={{ color: office.rent < 60000 ? 'red' : 'green' }}>
                ₹{office.rent}
              </span>
            </p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default OfficeList;
