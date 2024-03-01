import { useState } from 'react';
import './App.css';

function App() {
    const [showPopup, setShowPopup] = useState(false);
    const [generatedProp, setGeneratedProp] = useState();
    const [formValues, setFormValues] = useState({
        proposalID: '',
        companyName: '',
        address: '',
        amount: '',
        description: '',
        status: ''
    });

    const handleChange = (e) => {
        setFormValues({ ...formValues, [e.target.id]: e.target.value });
    };
    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(JSON.stringify(formValues));
        getProposal().then((response) => setGeneratedProp(response));
        setShowPopup(true);
    };

    async function getProposal() {
        const result = await fetch('http://localhost:5080/ConfigureProposal', {
            method: 'POST',
            body: JSON.stringify(formValues),
            headers: {
                'accept': 'text/plain',
                'Content-type': 'application/json'
            }
        });

        const proposalHtml = await result.text()
        console.log(proposalHtml)
        return proposalHtml;
    }

    return (
        <div>
            <h1 id="tabelLabel">Proposal Information</h1>
            <p>This component demonstrates filling a proposal template with inputed details.</p>
            <div className="form">
                <form onSubmit={handleSubmit}>
                    <div className="input-group">
                        <label htmlFor="name">Proposal ID:</label>
                        <input type="text" id="proposalID" value={formValues.proposalID || ""} onChange={handleChange} />
                    </div>
                    <div className="input-group">
                        <label htmlFor="email">Company Name:</label>
                        <input type="text" id="companyName" value={formValues.companyName || ""} onChange={handleChange} />
                    </div>
                    <div className="input-group">
                        <label htmlFor="email">Address:</label>
                        <input type="text" id="address" value={formValues.address || ""} onChange={handleChange} />
                    </div>
                    <div className="input-group">
                        <label htmlFor="email">Amount:</label>
                        <input type="text" id="amount" value={formValues.amount || ""} onChange={handleChange} />
                    </div>
                    <div className="input-group">
                        <label htmlFor="email">Proposal Description:</label>
                        <input type="text" id="description" value={formValues.description || ""} onChange={handleChange} />
                    </div>
                    <div className="input-group">
                        <label htmlFor="email">Status:</label>
                        <input type="text" id="status" value={formValues.status || ""} onChange={handleChange} />
                    </div>
                    <button type="submit" className="submit-btn">
                        Submit
                    </button>
                </form>
            </div>
            <div style={{ height: 20 + 'px' }} >
                {showPopup == true && <div dangerouslySetInnerHTML={{ __html: generatedProp }} />}
            </div>
        </div>
    );
}

export default App;
