import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [inputs, setForecasts] = useState();

    useEffect(() => {
        populateWeatherData();
    }, []);

    const contents = inputs === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <div className="form">
            <form>
                <div className="input-group">
                    <label htmlFor="name">Proposal ID:</label>
                    <input type="text" id="propID" />
                </div>
                <div className="input-group">
                    <label htmlFor="email">Company Name:</label>
                    <input type="text" id="compName" />
                </div>
                <div className="input-group">
                    <label htmlFor="email">Address:</label>
                    <input type="text" id="addr" />
                </div>
                <div className="input-group">
                    <label htmlFor="email">Amount:</label>
                    <input type="text" id="amount" />
                </div>
                <div className="input-group">
                    <label htmlFor="email">Proposal Description:</label>
                    <input type="text" id="propDesc" />
                </div>
                <div className="input-group">
                    <label htmlFor="email">Status:</label>
                    <input type="text" id="status" />
                </div>
                <button type="submit" className="submit-btn">
                    Submit
                </button>
            </form>
        </div>;

    return (
        <div>
            <h1 id="tabelLabel">Proposal Information</h1>
            <p>This component demonstrates filling a proposal template with inputed details.</p>
            {contents}
        </div>
    );

    async function populateWeatherData() {
        const response = await fetch('weatherforecast');
        const data = await response.json();
        setForecasts(data);
    }
}

export default App;