import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import './../nav-menu/nav-menu.css'

export default function NavMenu() {

    return (
        <Navbar collapseOnSelect expand="lg" className="bg-body-tertiary p-0 m-0">

            <Container className="bg-black" fluid>

                <Navbar.Brand id="nav-brand" href="/">Medical Center</Navbar.Brand>
                <Navbar.Toggle id="responsive-navbar-toggle" aria-controls="responsive-navbar-nav" />

                <Navbar.Collapse id="responsive-navbar-nav">
                    <Nav className="me-auto">

                        <Nav.Link className="text-white" href="/">Home</Nav.Link>
                        <Nav.Link className="text-primary" href="/download/index">Download</Nav.Link>
                        <Nav.Link className="text-primary" href="/upload/index">Upload</Nav.Link>

                    </Nav>
                    <Nav>
                        <Nav.Link className="text-white" href="#">welcome:</Nav.Link>
                        <Nav.Link className="text-white" eventKey={2} href="#">
                            Customer
                        </Nav.Link>
                    </Nav>

                </Navbar.Collapse>

            </Container>

        </Navbar>
    );

}