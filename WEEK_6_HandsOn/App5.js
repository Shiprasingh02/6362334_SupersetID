import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div style={{ padding: '20px' }}>
      <h2>Cohort Details</h2>
      <CohortDetails 
        cohortName="ReactJS July 2025" 
        status="ongoing" 
        startDate="2025-07-01" 
        endDate="2025-08-10" 
      />
      <CohortDetails 
        cohortName="Spring Boot June 2025" 
        status="completed" 
        startDate="2025-06-01" 
        endDate="2025-07-15" 
      />
    </div>
  );
}

export default App;

