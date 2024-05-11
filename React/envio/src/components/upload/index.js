import api from '../../services/upload/upload_api';
import 'bootstrap/dist/css/bootstrap.min.css'
import React, { useState, useEffect } from 'react';
import '../upload/upload.css'
import axios from 'axios';




const FileUpload = () => {
    const [selectedFile, setSelectedFile] = useState(null);

    const handleFileSelect = (event) => {
        setSelectedFile(event.target.files[0]);
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
        <form onSubmit={handleSubmit}>
            <input type="file" onChange={handleFileSelect} />
            <button type="submit">Upload</button>
        </form>
    );
};

export default FileUpload;






/*function Upload() {*/


    












    //const baseUrl = "https://localhost:7290/api/customer/post-csv-file"

    //const [data, setData] = useState([]);

    //const [dataFile, setDataFile] = useState({

    //    file:""

    //})

    //const handleChange = e => {

    //    const { name, value } = e.target;

    //    setDataFile({

    //        ...dataFile, [name] : value

    //    });

    //    console.log("ok")
    //}


    //const postFile = async() => {

    //    await axios.post(baseUrl, dataFile)
    //        .then(response => {

    //            setDataFile(data.concat(response.data));

    //        }).catch(error => {

    //            console.log(error);

    //        })
    //}


    //return (

    //    <div className="upload-container">

    //        <div className="d-flex align-items-xl-center justify-content-center windows">

    //           {/* <form>*/}

    //                <div className="panel panel-default text-center">
    //                    <div className="input-group mb-3">

    //                        <button className="btn btn-dark" id="inputGroupFileAddon03" onClick={()=> postFile()}> Upload </button>

    //                        <input type="file" name="file" className="form-control" id="inputGroupFile03" multiple required
    //                            aria-describedby="inputGroupFileAddon03" aria-label="Upload"
    //                            onChange={handleChange}
    //                        />
    //                    </div>
    //                </div>

    //          {/*  </form>*/}

    //        </div>

    //    </div>
    //);

//}

//export default Upload;









