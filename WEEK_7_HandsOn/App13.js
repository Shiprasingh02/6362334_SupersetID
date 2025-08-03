// src/App.js
import React, { useState } from 'react';
import './App.css';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [view, setView] = useState("book"); // "book" | "blog" | "course"

  // 1️⃣ Using if...else
  let content;
  if (view === "book") {
    content = <BookDetails />;
  } else if (view === "blog") {
    content = <BlogDetails />;
  } else {
    content = <CourseDetails />;
  }

  // 2️⃣ Using ternary (just for title display)
  const heading = view === "book"
    ? "Book Section"
    : view === "blog"
    ? "Blog Section"
    : "Course Section";

  return (
    <div className="App">
      <h1>📘 Blogger App</h1>
      <h2>{heading}</h2>

      {/* Buttons to change view */}
      <div style={{ marginBottom: '20px' }}>
        <button onClick={() => setView("book")}>Show Book</button>
        <button onClick={() => setView("blog")}>Show Blog</button>
        <button onClick={() => setView("course")}>Show Course</button>
      </div>

      {/* 3️⃣ Rendering using element variable */}
      {content}

      {/* 4️⃣ Short-circuit rendering */}
      <div style={{ marginTop: '20px' }}>
        {view === "book" && <p>📌 You're currently viewing a book.</p>}
        {view === "blog" && <p>📌 You're currently reading a blog.</p>}
        {view === "course" && <p>📌 You're browsing course info.</p>}
      </div>
    </div>
  );
}

export default App;
