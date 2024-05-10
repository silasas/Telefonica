import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import NavMenu from './components/nav-menu';
import Home from './components/home'
import Download from './components/download'
import Upload from './components/upload'

export default function Main() {

    return (

        <BrowserRouter>

            <NavMenu />

            <Routes>
                <Route path="/" element={<Home />} exact />
                <Route path="/download" element={<Download />} exact />
                <Route path="/upload" element={<Upload />} exact />
            </Routes>
        </BrowserRouter>

    )
}