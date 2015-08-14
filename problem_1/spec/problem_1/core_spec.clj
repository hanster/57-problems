(ns problem-1.core-spec
  (:require [speclj.core :refer :all]
            [problem-1.core :refer :all]))

(describe "saying hello"
  (it "says hello with the input value"
    (should= "Enter your name: \nHello Sam!\n"
      (with-out-str (with-in-str "Sam"
                      (say-hello))))))
