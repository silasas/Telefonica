import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import SSRProvider from 'react-bootstrap/SSRProvider'

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
       {/* <App />*/}

        <SSRProvider>
            <App />
        </SSRProvider>

  </React.StrictMode>
);
