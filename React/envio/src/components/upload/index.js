import 'bootstrap/dist/css/bootstrap.min.css'
import React, { useState } from 'react';
import '../upload/upload.css'

function Upload() {

    const [selectedFile, setSelectedFile] = useState(null);

    const handleFileChange = (event) => {
        const file = event.target.files[0];
        setSelectedFile(file);
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        if (selectedFile) {
            // Faça o upload do arquivo aqui ou realize outras ações necessárias
            console.log('Arquivo selecionado:', selectedFile.name);
        }
    };

    return (

        <div className="upload-container">

            <div className="d-flex align-items-xl-center justify-content-center windows">
        
                <form onSubmit={handleSubmit}>

                    <div className="panel panel-default text-center">
                        <div className="input-group mb-3">
                            <button className="btn btn-dark" type="button" id="inputGroupFileAddon03">Button</button>
                            <input type="file" className="form-control" id="inputGroupFile03"
                                aria-describedby="inputGroupFileAddon03" aria-label="Upload" />
                        </div>
                    </div>

                </form>

            </div>

        </div>
    );
}

export default Upload;









