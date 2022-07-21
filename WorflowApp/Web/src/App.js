import './App.css';
import { Home } from './Home';
import { Demande } from './Components/Demande';
import { TypeDemande } from './Components/TypeDemande';
import { Navigation } from './Navigation';

import { BrowserRouter, Route, Routes} from 'react-router-dom';

function App(){

  // useEffect(() => {
  //   axios.get('https://localhost:7076/Demandes')
  //     .then((response) => {
  //       console.log(response.data);
  //     })
  // }, [])
  return (
    <BrowserRouter>
    <div className='container' >

    <h3 className="m-3 d-flex justify-content-center">App web AWM</h3>
    
    <Navigation/>
    <Routes>
    <Route path="/" element={<Home />} />
    <Route path="Demande" element={<Demande />} />
    <Route path="TypeDemande" element={<TypeDemande />} />
    </Routes>

    </div>
    </BrowserRouter>

  );
}

export default App;