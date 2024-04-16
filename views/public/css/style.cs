svg {
  height: 23rem;
  margin-right: 4rem;
}

#envelope {
  animation: float 2s ease-in-out infinite;
}

#star1, #star2, #star3, #star4, #star5, #star6 {
  animation: blink 1s ease-in-out infinite;
}

#star2 {
  animation-delay: 100ms;
}

#star3 {
  animation-delay: 500ms;
}

#star4 {
  animation-delay: 700ms;
}

#star5 {
  animation-delay: 300ms;
}

#star6 {
  animation-delay: 200ms;
}

@keyframes float {
  0% {
    transform: translateY(0px);
  }
  50% {
    transform: translateY(-20px);
  }
  100% {
    transform: translateY(0px);
  }
}
@keyframes blink {
  0% {
    opacity: 0;
  }
  50% {
    opacity: 0.5;
  }
  100% {
    opacity: 1;
  }
}
.container {
  height: 100vh;
}

form {
  min-width: 25rem;
}
form .title {
  font-family: "Pacifico", cursive;
  color: #212529;
  font-size: 2.5rem;
}
form .form-control {
  background-color: #f2f6f8;
  border-radius: 2rem;
  border: none;
  box-shadow: 0px 7px 5px rgba(0, 0, 0, 0.11);
}
form .form-control.thick {
  height: 3.3rem;
  padding: 0.5rem 3.5rem;
}
form .form-control:focus {
  background-color: #f2f6f8;
  border: none;
  box-shadow: 0px 7px 5px rgba(0, 0, 0, 0.11);
}
form .message .form-control {
  padding: 0.5rem 2.0rem;
}
form ::placeholder {
  font-family: "Quicksand", sans-serif;
  font-weight: 600;
  font-size: 1.1rem;
  color: #838788;
  position: relative;
  left: 0;
}
form input,
form textarea {
  font-family: "Quicksand", sans-serif;
  color: #212529;
  font-size: 1.1rem;
}
form .icon {
  color: #57565c;
  height: 1.3rem;
  position: absolute;
  left: 1.5rem;
  top: 1.1rem;
}

.btn.btn-primary {
  font-family: "Quicksand", sans-serif;
  font-weight: bold;
  height: 2.5rem;
  line-height: 2.5rem;
  padding: 0 3rem;
  border: 0;
  border-radius: 3rem;
  background-image: linear-gradient(131deg, #ffd340, #ff923c, #ff923c, #ff923c);
  background-size: 300% 100%;
  transition: all 0.3s ease-in-out;
}

.btn.btn-primary:hover:enabled {
  box-shadow: 0 0.5em 0.5em -0.4em #ff923cba;
  background-size: 100% 100%;
  transform: translateY(-0.15em);
}