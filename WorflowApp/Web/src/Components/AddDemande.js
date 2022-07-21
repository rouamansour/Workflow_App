import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';

export class AddDemande extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event) {
        event.preventDefault();
        fetch(process.env.REACT_APP_API + 'demandes', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                Id: null,
                number: event.target.number.value,
                title: event.target.title.value,
                Comment: event.target.Comment.value,
                deadline: event.target.deadline.value
            })
        })
            .then(res => res.json())
            .then((result) => {
                alert(result);
            },
                (error) => {
                    alert('Failed');
                })
    }
    render() {
        return (
            <div className="container">

                <Modal
                    {...this.props}
                    size="lg"
                    aria-labelledby="contained-modal-title-vcenter"
                    centered
                >
                    <Modal.Header closeButton>
                        <Modal.Title id="contained-modal-title-vcenter">
                            Add Demande
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>

                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                    <Form.Group controlId="Dtitle">
                                        <Form.Label>Number</Form.Label>
                                        <Form.Control type="number" name="Number" required
                                            placeholder="Number" />
                                        <Form.Label>Title</Form.Label>
                                        <Form.Control type="text" name="Title" required
                                            placeholder="Title" />
                                        <Form.Label>Comment</Form.Label>
                                        <Form.Control type="text" name="Comment" required
                                            placeholder="Comment" />
                                        <Form.Label>Deadline</Form.Label>
                                        <Form.Control type="date" name="Deadline" required
                                            placeholder="Deadline" />
                                    </Form.Group>

                                    <Form.Group>
                                        <Button variant="primary" type="submit">
                                            Add Demande
                                        </Button>
                                    </Form.Group>
                                </Form>
                            </Col>
                        </Row>
                    </Modal.Body>

                    <Modal.Footer>
                        <Button variant="danger" onClick={this.props.onHide}>Close</Button>
                    </Modal.Footer>

                </Modal>

            </div>
        )
    }

}