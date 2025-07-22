import React from 'react';
import { Outlet } from 'react-router-dom';
import Navbar from './components/Navbar';
import { CssBaseline, Box } from '@mui/material';

const App: React.FC = () => {
  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
      <CssBaseline />
      <Navbar />
      <Box component="main" sx={{ flexGrow: 1 }}>
        <Outlet />
      </Box>
    </Box>
  );
};

export default App;
