import api from '../../services/download/download_api';
import { Link, useNavigate } from 'react-router-dom';
import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../download/download.css'


function Download() {


    const [customer, setCustomer] = useState([])


    useEffect(() => {

        Load()

    })

    async function Load() {

        try {

            api.get('customer/get-customers').then(

                response => {
                    setCustomer(response.data)
                    console.log(response.data)
                }
            )


        } catch (error) {

            console.log(error)
        }
    }


    return (
        <div className="download-container">

            <div className="card mb-3 mt-2">
                <h5 className="text-center card-header bg-black text-white h5"> </h5>
                <h5 className="text-center card-header text-white h5 mb-1" style={{ background: "#2f506c" }}>List of customers</h5>
            </div>

            <table className="table table-hover table-striped">
                <thead>
                    <tr className="bg-primary text-white">
                        <th>
                            Customer code
                        </th>
                        <th>
                            Product code
                        </th>
                        <th>
                            Firstname
                        </th>
                        <th>
                            Middlename
                        </th>
                        <th>
                            Surname
                        </th>
                        <th>
                            Product
                        </th>
                        <th>
                            Price
                        </th>
                    </tr>
                </thead>

                <tbody>

                    {customer.map(s => (
                        <tr key={s.id}>
                            <td>
                                {s.customercode}
                            </td>
                            <td>
                                {s.productcode}
                            </td>
                            <td>
                                {s.firstname}
                            </td>
                            <td>
                                {s.middlename}
                            </td>
                            <td>
                                {s.surname}
                            </td>
                            <td>
                                {s.product}
                            </td>
                            <td>
                                {s.price}
                            </td>

                            {/*<button onClick={() => editAluno(aluno.id)} type="button">*/}
                            {/*    <FiEdit size="25" color="#17202a" />*/}
                            {/*</button>*/}

                     {/*       <td><Link onClick={() => Edit(s)} className="btn"><i className="fas fa-edit"></i>&nbsp;Editar</Link></td>*/}
                            <td><Link className="btn"><i className="fas fa-info"></i>&nbsp;Detalhe</Link></td>
                            <td><Link className="btn"><i className="fas fa-trash"></i>&nbsp;Deletar</Link></td>
                        </tr>
                    ))}

                </tbody>
            </table>

        </div>
    );
}

export default Download;