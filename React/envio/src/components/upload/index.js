import 'bootstrap/dist/css/bootstrap.min.css'
import React, { useState } from 'react';
import '../upload/upload.css'
import axios from 'axios';


const FileUpload = () => {
    const [selectedFile, setSelectedFile] = useState(null);

    const handleFileSelect = (event) => {
        setSelectedFile(event.target.files[0]);

        const file = event.target.files[0];

        if (file && file.name === 'arquivo_lote.csv') {

            setSelectedFile(file);

        } else {

            alert('Por favor, selecione o arquivo "arquivo_lote.csv".');
            window.location.reload(false);
        }

    };

    const handleSubmit = async (event) => {
        event.preventDefault();

        const formData = new FormData();
        formData.append('file', selectedFile);

        try {
            const response = await axios.post('https://localhost:7290/api/customer/post-csv-file', formData, {

                headers: {
                    'Content-Type': 'multipart/form-data',
                },
            });

            console.log('Upload successful:', response.data);

        } catch (error) {

            console.error('Error uploading file:', error);

        }
    };

    return (

        <div className="upload-container">

            <div className="d-flex align-items-xl-center justify-content-center" style={{ height: "700px" }}>

                <form onSubmit={handleSubmit}>

                    <div className="panel panel-default text-center">
                        <div className="input-group mb-3">

                            <button type="submit" className="btn btn-dark" id="inputGroupFileAddon03"> Upload </button>

                            <input type="file" accept=".csv" name="file" className="form-control" id="inputGroupFile03" multiple required
                                aria-describedby="inputGroupFileAddon03" aria-label="Upload"
                                onChange={handleFileSelect}
                            />

                        </div>
                    </div>
                </form>
            </div>
        </div>
    );
};


export default FileUpload;