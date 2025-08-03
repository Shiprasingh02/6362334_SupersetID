// src/App.js
import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate, useNavigate } from 'react-router-dom';
import GuestPage from './GuestPage';
import UserPage from './UserPage';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  return (
    <Router>
      <div className="App">
        <h1>✈ Ticket Booking App</h1>
        <Routes>
          <Route path="/guest" element={<GuestView setIsLoggedIn={setIsLoggedIn} />} />
          <Route
            path="/user"
            element={
              isLoggedIn ? (
                <UserView setIsLoggedIn={setIsLoggedIn} />
              ) : (
                <Navigate to="/guest" />
              )
            }
          />
          <Route path="*" element={<Navigate to="/guest" />} />
        </Routes>
      </div>
    </Router>
  );
}

// Wrapper for GuestPage with login button
function GuestView({ setIsLoggedIn }) {
  const navigate = useNavigate();
  const handleLogin = () => {
    setIsLoggedIn(true);
    navigate('/user');
  };

  return (
    <div>
      <button onClick={handleLogin}>Login</button>
      <GuestPage />
    </div>
  );
}

// Wrapper for UserPage with logout button
function UserView({ setIsLoggedIn }) {
  const navigate = useNavigate();
  const handleLogout = () => {
    setIsLoggedIn(false);
    navigate('/guest');
  };

  return (
    <div>
      <button onClick={handleLogout}>Logout</button>
      <UserPage />
    </div>
  );
}

export default App;
