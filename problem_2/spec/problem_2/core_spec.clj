(ns problem-2.core-spec
  (:require [speclj.core :refer :all]
            [problem-2.core :refer :all]))

(describe "counting characters"
  (it "returns the length of a word"
    (should= 0 (character-count "")))
  (it "one for a single character"
    (should= 1 (character-count "w")))
  (it "returns 5 for a five character word"
    (should= 5 (character-count "about"))))

(describe "counts and displays the number of characters"
  (it "prompts for input and displays the number of characters"
    (should-contain "House has 5 characters"
      (with-out-str (with-in-str "House"
                      (character-counter))))))
