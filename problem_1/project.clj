(defproject problem_1 "0.1.0-SNAPSHOT"
  :description "Problem 1 of 57"
  :url "https://github.com/hanster/57-problems"
  :license {:name "Eclipse Public License"
            :url "http://www.eclipse.org/legal/epl-v10.html"}
  :dependencies [[org.clojure/clojure "1.7.0-RC2"]]
  :main problem-1.core
  :profiles {:dev {:dependencies [[speclj "3.3.1"]]}}
  :plugins [[speclj "3.3.1"]]
  :test-paths ["spec"])
