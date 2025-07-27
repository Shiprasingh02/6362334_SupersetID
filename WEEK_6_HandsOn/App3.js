import React from 'react';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name="Shipra Singh" 
        School="Green Valley High School" 
        Total={450} 
        Goal="Top 5 in Class"
      />
    </div>
  );
}

export default App;

