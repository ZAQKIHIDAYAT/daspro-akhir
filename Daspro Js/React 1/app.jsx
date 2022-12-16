class App extends React.Component{
    constructor(props){
      super(props);
      this.state = {
        name:props.name,
        elements: []
      }
    }
    
    changeName(){
      this.setState({
        name:'React Native'
      });
    }
    
    changeMessageInput(event){
      this.setState({
        message:event.target.value
      });
    }
    
    addElement(){
      const oldElements = this.state.elements;
      this.setState({
        elements:oldElements.concat(oldElements.length + 1)
      });
    }
    
    render(){
      let updateParagraph = '';
      let nameParagraphClass = ''
      
      if(this.state.name != this.props.name){
         updateParagraph = <p>Name Updated!</p>
         nameParagraphClass = 'update'
      }
      let list = this.state.elements.map(
         (el) => {
            return <li key={el} style={ { 'background-color' : 'red' } }>{el}</li>
         }
      );
      return (
      <div>
         <p className={nameParagraphClass}>{this.state.name}</p>
         {updateParagraph}
         <button onClick ={this.changeName.bind(this)}>Change Name</button>
         <button onClick ={this.addElement.bind(this)}>New Element</button>
         <ul>
           {list}
         </ul>
         <input type='text'
         value={this.state.message}
         onChange={this.changeMessageInput.bind(this)}></input>
         <p>{this.state.message}</p>
      </div>
      );
    }
  }
  
  //const element = React.createElement('p',null,'React Framework');
  ReactDOM.render(<App name = 'React.js' />,document.querySelector('#app'));